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
  map(({ target }) => calculateScrollPercentage(target.scrollingElement))
);
progressStream.subscribe(
  (percent) =>
    (document.querySelector(".progress-bar").style.width = `${percent}%`)
);
