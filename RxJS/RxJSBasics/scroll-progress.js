import { fromEvent } from "rxjs";
import { map } from "rxjs/operators";

function calculateScrollPercentage(element) {
  // Using object destructuring to get the necessary values from the document
  const { scrollTop, scrollHeight, clientHeight } = element;

  console.log(scrollTop + " " + scrollHeight + " " + clientHeight);
  return (scrollTop / (scrollHeight - clientHeight)) * 100;
}

const scrollStream = fromEvent(document, "scroll");

const progressStream = scrollStream.pipe(
  // Again, need to use object destructuring to get the target from the scroll event
  map(({ target }) => calculateScrollPercentage(target.scrollingElement))
);

// Update the progress bar element with the percentage obtained from the progress stream above
progressStream.subscribe(
  (percent) =>
    (document.querySelector(".progress-bar").style.width = `${percent}%`)
);
