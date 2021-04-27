// Demonstrating how Observables work
import { Observable } from "rxjs";

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
observable.subscribe(observffdsakjasdfjklsdsafer);

// It's also possible to directly pass the required functions instead of an object
observable.subscribe(
  (value) => console.log("next", value),
  (error) => console.log("error", error),
  () => console.log("complete!")
);
