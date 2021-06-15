import { Observable, fromEvent, of, range, from, interval, timer } from "rxjs";
import {
  map,
  filter,
  reduce,
  scan,
  tap,
  take,
  first,
  takeWhile,
  takeUntil,
  distinctUntilChanged,
  distinctUntilKeyChanged,
  debounceTime,
  pluck,
  throttleTime,
  sampleTime,
  sample,
} from "rxjs/operators";

// Observables are "streams" of data. They provide the ability to asynchronously "emit" or "push" events to items that need to react to those events.

// A new Observable accepts a function which accepts a subscriber, which it will call when it has completed its operation.
// The "subscriber", then, is an object that "observes" the observer and reacts to its events.
const observable = new Observable((subscriber) => {
  // Calling next "pushes" (aka "emits") a value to the subscriber
  subscriber.next("Hello");
  subscriber.next("World");
  // Calling complete signals to the subscriber that no more events will be emitted
  subscriber.complete();
});

// A Subscriber is an object that reacts to events pushed from an Observer.
// A subscriber is a "wrapped, safe version" of an observer. They can be more-or-less thought of as the same thing.
const subscriber = {
  // A subscriber/observer needs 3 "callback" functions. Note that if any of these are not defined, they will be stubbed out with default implementations.

  // next is for reacting to normal events emitted from the observable
  next: (value) => console.log("next", value),

  // error is for reacting to errors emitted by the observable
  error: (error) => console.log("error", error),

  // complete is for reacting to the observable completing it's operation. Once complete is called by an observable,
  // the subscriber won't accept/react to any more events.
  complete: () => console.log("complete!"),
};

// subscribe hooks the observer/subscriber to the observable and triggers the observable to emit its events.
// Observables are "cold" and won't do anything until subscribe is called.
observable.subscribe(subscriber);

// It's also possible to directly pass the required functions instead of an object
observable.subscribe(
  (value) => console.log("next2", value),
  (error) => console.log("error2", error),
  () => console.log("complete2!")
);

// Demonstrating how Observables can deliver values asynchronously
const asynchronousObservable = new Observable((subscriber) => {
  let count = 0;

  // setInterval is a standard JavaScript function that accepts a function which will execute in a loop on a given delay (in this case 1000ms)
  const id = setInterval(() => {
    subscriber.next(count);
    count += 1;
  }, 1000);

  // We can return a "clean-up" function from this function that will be called whenever a subscriber unsubscribes from an observable (see below)
  return () => {
    console.log("clean-up function called");
    clearInterval(id);
  };
});

console.log("before");

// Calling subscribe actually returns a "subscription" object, which allows the observable to be cancelled by calling "unsubscribe".
// Unsubscribe calls the function that is "returned" in the function passed to the Observable constructor (the "clean up" function we defined above).
const subscription = asynchronousObservable.subscribe(subscriber);
setTimeout(() => {
  subscription.unsubscribe();
}, 3500);

// This will be printed before anything in the observable is emitted, because the call to "subscribe" is asynchronous, and we introduced a delay in the observable
console.log("after");

// Subscriptions can also be "added" together and cleaned up all at once
const subscription2 = asynchronousObservable.subscribe(subscriber);
const subscription3 = asynchronousObservable.subscribe(subscriber);
subscription2.add(subscription3);
setTimeout(() => {
  subscription2.unsubscribe();
}, 2000);

// Demonstrating "creation operators" for Observables. These are standalone functions that create Observables from a "producer" of data (aka a "source").
// These operators allow us to not have to manually call the Observable constructor and manage it as we did above.

// The "fromEvent" creation operator creates an observable from some DOM event, such as a mouse click on an element
const source = fromEvent(document, "click");

// The value pushed to the observer in this case will be the details of the mouse click event
const observer = {
  next: (val) => console.log("next", val),
  error: (err) => console.log("error", err),
  complete: () => console.log("complete!"),
};

const subOne = source.subscribe(observer);

// It's very important to clean up subscriptions to prevent memory leaks. There are ways to automate we will see later on.
setTimeout(() => {
  console.log("unsubscribing");
  subOne.unsubscribe();
}, 3000);

// The "of" creation operator crates an observable from some a comma-separated list of data
const source2 = of(1, 2, 3, 4, 5);
source2.subscribe(observer);
// "of" is synchronous (i.e. Hello will be printed after the observable is finished)
console.log("Hello");

// The equivalent behavior with the "range" operator would be:
range(1, 5);

// Demonstrating the "from" creation operator
// from is a "more intelligent" version of "of" that accepts lists, iterators, promises, etc.

// This has the same behavior as the "of" call above
from([1, 2, 3, 4, 5]);

// "fetch" does an HTTP request and returns a Promise, which we can pass to the from operator. This will operate asynchronously and will only
// emit once a response is received for the request
const source3 = from(fetch("https://api.github.com/users/octocat"));
source3.subscribe(observer);

// Demonstrating the "internal" operator.
// interval accepts a duration in milliseconds that will control how often a value is emitted. The values emitted are simply numbers in a sequence.
const timer$ = interval(1000);
// Remember - any function we supply to "subscribe" will simply become the "next" callback for the observable.
const subscriptionToTimer = timer$.subscribe(console.log);

setTimeout(() => {
  subscriptionToTimer.unsubscribe();
}, 10000);

// Demonstrating pipeable operators
// Operators can perform operations on data in observable streams
// Operators are like members of an assembly line - each item makes its way through each piped operator before getting to the observer(s)
// Each operator called on an observable itself returns an observable, with its items manipulated or transformed in some way. This allows
// the original observable to remain unchanged.
// Operators on a stream are passed as arguments to the "pipe" function, which is called on the observable itself.

// The "map" operator transforms each item by applying some function to each
of(1, 2, 3, 4, 5)
  .pipe(map((value) => value * 10))
  .subscribe(console.log);

// Typically, this would be done on some dynamic stream, such as DOM events
fromEvent(document, "keyup")
  .pipe(map((event) => event.code))
  .subscribe(console.log);

// Demonstrating the filter operator, which will limit the values emitted from an observable based on some conditional function
fromEvent(document, "keyup")
  .pipe(filter((event) => event.code === "Enter"))
  .subscribe(() => console.log("Enter pushed!"));

// See scroll-progress.js for a more involved example of pipeable operators

// Demonstrating the "reduce" operator
// Reduce can accumulate data in a stream in various ways.
const numbers = [1, 2, 3, 4, 5];
const numbersStream = from(numbers);

// reduce accepts a function which accepts two values. The first value is the "previous" value; i.e. the value returned by the function the last time it was
// called (obviously on the first call this will be "empty"). The "current" value is simply substituted with each value in the stream.
const sumFunction = (previousValue, currentValue) => {
  console.log({ previousValue, currentValue });
  return previousValue + currentValue;
};

numbersStream
  // In this scenario, reduce will emit the sum of the numbers in the stream
  .pipe(reduce(sumFunction))
  .subscribe((sum) => console.log("Reduced sum: " + sum));

// Demonstrating the "scan" operator
// scan is similar to reduce, except that it emits after each call is made to its callback, rather than waiting till the end of the stream like reduce
numbersStream
  .pipe(scan(sumFunction))
  .subscribe((sum) => console.log("Scanned sum: " + sum));

// scan can be used to monitor the "state" of some data over time

// Think of this like the state of the Brian user over time
const userState = [
  { name: "Brian", loggedIn: false, token: null },
  { name: "Brian", loggedIn: true, token: null },
  { name: "Brian", loggedIn: true, token: "123" },
];
from(userState)
  .pipe(
    scan((previousValue, currentValue) => {
      // Using the "spread" operator to update the object's values
      return { ...previousValue, ...currentValue };
    }, {}) // for non-trivial-type items, we need to supply a "seed" value to the scan (and reduce) operators so that the "previousValue" has an initial value
  )
  .subscribe(console.log);

// See countdown.js for a more involved example of scan and filter

// Demonstrating the "tap" operator
// tap allows us to "spy" on a stream
const anotherNumbersStream = of(1, 2, 3, 4, 5);
anotherNumbersStream
  .pipe(
    tap((value) => console.log("before mapping: " + value)),
    map((value) => value * 10),
    tap((value) => console.log("after mapping: " + value))
  )
  .subscribe();

// There is a temptation to have tap "do" things and perform side-effects, but this is generally not good practice.

// Demonstrating "filtering" operators

// The "take" operator limits the amount of items an observable stream emits

const numbersStreamForTakeOp = of(1, 2, 3, 4, 5);
numbersStreamForTakeOp.pipe(take(3)).subscribe({
  next: (num) => console.log("Emitting take value of " + num),
  complete: () => console.log("Complete!"),
});

// The "first" operator is sort of a combination of filter and take - it will emit the first time a predicate is satisfied, and never again
const numberStreamForFirstOp = of(1, 2, 3, 4, 5);
numberStreamForFirstOp
  .pipe(
    first((value) => value > 3) // should emit 4
  )
  .subscribe((value) => console.log("Emitting from first operator: " + value));

// The "takeWhile" operator emits values until its predicate is found to be false
const numberStreamForTakeWhileOp = of(1, 2, 3, 4, 5);
numberStreamForTakeWhileOp
  .pipe(takeWhile((value) => value <= 3)) // should emit until 3 is reached
  .subscribe((value) =>
    console.log("Emitting from takeWhile operator: " + value)
  );

// The "takeUntil" operator is unique in that it accepts another observable as its argument.
// The observable on which takeUntil is called will emit until the observable that is passed to takeUntil emits a value
const numbersStreamForTakeUntilOp = interval(1000);
const clickStream = fromEvent(document, "click");
numbersStreamForTakeUntilOp.pipe(takeUntil(clickStream)).subscribe({
  next: (value) => console.log("Emitting until click! " + value),
  complete: () =>
    console.log("Received a click so stopping the takeUntil stream"),
});

// The "distinctUntilChanged" operator will only emit values that are unique/distinct from the previous emitted value
const numbersStreamForDistinctUntilChangedOp = of(1, 1, 2, 2, 3, 4, 4, 5);
numbersStreamForDistinctUntilChangedOp
  .pipe(distinctUntilChanged())
  .subscribe((value) =>
    console.log(
      "Emitting unique " + value + " from distinctUntilChanged operator"
    )
  );

// distinctUntilChanged compares using === by default, but you can provide your own "comparator" function
const userState2 = [
  { name: "Evan", loggedIn: false, token: null },
  { name: "Evan", loggedIn: true, token: null },
  { name: "Brian", loggedIn: true, token: "123" },
];
from(userState2)
  .pipe(
    scan((previousValue, currentValue) => {
      return { ...previousValue, ...currentValue };
    }, {}),
    distinctUntilChanged((prev, curr) => prev.name === curr.name)
  )
  .subscribe((value) =>
    console.log(
      "With distinctUntilChanged, emitting user " +
        value.name +
        " since the name is unique"
    )
  );

// distinctUntilKeyChanged is a helper function for distinctUntilChanged that simplifies comparator functions. You can simply provide
// the property on which to compare each pair of items, and the operator will compare those with ===
from(userState2)
  .pipe(
    scan((previousValue, currentValue) => {
      return { ...previousValue, ...currentValue };
    }, {}),
    distinctUntilKeyChanged("name")
  )
  .subscribe((value) =>
    console.log(
      "With distinctUntilKeyChanged, emitting user " +
        value.name +
        " since the name is unique"
    )
  );

// Demonstrating "rate-limiting" operators
// Rate-limiting operators are special time-based filtering operators

// The "debounceTime" operator only emits items that arrive in the stream after a specified amount of time
const click$ = fromEvent(document, "click");
click$
  .pipe(debounceTime(1000)) //only emit click events that arrive 1 second after the last received click
  .subscribe(() => console.log("debounceTime allowing click after 1 second"));

// Another example using debounceTime - logging user input on keyUp, but only if 1 second has passed since the last emitted event
const inputBox = document.getElementById("text-input");
const inputStream = fromEvent(inputBox, "keyup");
inputStream
  .pipe(
    debounceTime(1000),
    // Let's also map the key events to the values actually input into the text box, and ignore the non-unique values
    map((event) => event.target.value),
    distinctUntilChanged()
  )
  .subscribe(() => console.log("Text box content: " + inputBox.value));

// The "throttleTime" operator is similar to debounceTime, but it is not based on the time since the last emitted item, just a general fixed interval.
// By default, it will ignore items received during that window, and only emit any events received at the beginning of the interval.
const clickStreamWithThrottleTimeOp = fromEvent(document, "click");
clickStreamWithThrottleTimeOp
  .pipe(throttleTime(3000)) // only emit events received every 3 seconds
  .subscribe(() =>
    console.log("throttleTime allowing click event after 3 seconds")
  );

// See scroll-progress.js for an example of a slightly different usage of throttleTime

// sampleTime emits the most recent item received from a source observable, based on a time interval. Earlier items received within that interval window
// are simply ignored
const clickStream2 = fromEvent(document, 'click');
clickStream2.pipe(sampleTime(4000), map(({clientX, clientY}) => ({
  clientX, clientY
}))).subscribe((value) => console.log("Using sampleTime, most recent click position received in the last 4 seconds: X = " + value.clientX + ", Y = " + value.clientY));

// sample is similar to sampleTime, but emits based on the output of another observable (the "notifier"), instead of a fixed time interval
// This example is effectively the same as the one above, but uses "sample" and a source time interval observable (and emits every 6 seconds instead of 4)
const clickStream3 = fromEvent(document, 'click');
const timerStream = interval(6000); 
clickStream3.pipe(sample(timerStream), map(({clientX, clientY}) => ({
  clientX, clientY
}))).subscribe((value) => console.log("Using sample, most recent click position received in the last 6 seconds: X = " + value.clientX + ", Y = " + value.clientY));
