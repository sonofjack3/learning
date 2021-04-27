// Demonstrating how Observables work
import { async, Observable } from "rxjs";

// Observables provide the ability to asynchronously "emit" or "push" events to items that need to react to those events

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

// subscribe hooks the observer/subscriber to the observable and triggers the observable to emit its events
observable.subscribe(subscriber);

// It's also possible to directly pass the required functions instead of an object
observable.subscribe(
  (value) => console.log("next2", value),
  (error) => console.log("error2", error),
  () => console.log("complete2!")
);

// Demonstrating how Observables can delivery values asynchronously
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
// Unsubscribe calls the function that is "returned" in the function passed to the Observable constructor.
const subscription = asynchronousObservable.subscribe(subscriber);
setTimeout(() => {
  subscription.unsubscribe();
}, 3500);

// This will be printed before anything in the observable is emitted, because the call to "subscribe" is asynchronous, and we introduced a delay
console.log("after");

// Subscriptions can also be "added" together and cleaned up all at once
const subscription2 = asynchronousObservable.subscribe(subscriber);
const subscription3 = asynchronousObservable.subscribe(subscriber);
subscription2.add(subscription3);
setTimeout(() => {
  subscription2.unsubscribe();
}, 2000);
