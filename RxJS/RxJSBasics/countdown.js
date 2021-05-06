import { fromEvent, interval } from "rxjs";
import {
  scan,
  mapTo,
  startWith,
  filter,
  takeWhile,
  takeUntil,
} from "rxjs/operators";

const countdownElement = document.getElementById("countdown");
const messageElement = document.getElementById("message");
const abortButton = document.getElementById("abort");

const abortClickStream = fromEvent(abortButton, "click");

const counterStream = interval(1000)
  .pipe(
    scan((accumulator, currentValue) => {
      // Rather than actually using the value from interval, which is always going up, we can just subtract 1 on each emit
      return accumulator - 1;
    }, 10), // start the seed for scan at 10
    takeWhile((value) => value >= 0), // stop once 0 is reached
    takeUntil(abortClickStream) // stop the countdown if the abort button is clicked
  )
  .subscribe((value) => {
    countdownElement.innerHTML = value;
    if (value === 0) {
      messageElement.innerHTML = "Liftoff!";
    }
  });
