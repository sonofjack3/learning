import { interval } from "rxjs";
import { scan, mapTo, startWith, filter } from "rxjs/operators";

const countdownElement = document.getElementById("countdown");
const messageElement = document.getElementById("message");

const counterStream = interval(1000)
  .pipe(
    scan((accumulator, currentValue) => {
      // Rather than actually using the value from interval, which is always going up, we can just subtract 1 on each emit
      return accumulator - 1;
    }, 10), // start the seed for scan at 10
    filter((value) => value >= 0) // filter out negatives. In practice, we'd actually want to "complete" the stream once 0 is reached. This will be demonstrated later.
  )
  .subscribe((value) => {
    countdownElement.innerHTML = value;
    if (value === 0) {
      messageElement.innerHTML = "Liftoff!";
    }
  });
