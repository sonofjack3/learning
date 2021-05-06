import { fromEvent } from "rxjs";
import { map, throttleTime } from "rxjs/operators";
import { asyncScheduler } from "rxjs";

function calculateScrollPercentage(element) {
  // Using object destructuring to get the necessary values from the document
  const { scrollTop, scrollHeight, clientHeight } = element;

  console.log(scrollTop + " " + scrollHeight + " " + clientHeight);
  return (scrollTop / (scrollHeight - clientHeight)) * 100;
}

const scrollStream = fromEvent(document, "scroll");

const progressStream = scrollStream.pipe(
  // throttleTime ignores events outside of the given interval (i.e. only accepts events received every 20ms here).
  // It also accepts an asyncScheduler and a third argument that specifies whether to emit events received before the leading/trailing edge
  // of the "silence window" defined by the interval. By default, it emits the last event received just before the silence window begins (leading edge);
  // however, doing this means that any events received during that window are lost. In this example, doing that would mean that the user could
  // scroll during the silence window, and the progress bar would not get updated. Therefore, we want to emit events on the trailing edge of
  // the silence window.
  throttleTime(20, asyncScheduler, {
    leading: false,
    trailing: true,
  }),
  // Again, need to use object destructuring to get the target from the scroll event
  map(({ target }) => calculateScrollPercentage(target.scrollingElement))
);

// Update the progress bar element with the percentage obtained from the progress stream above
progressStream.subscribe(
  (percent) =>
    (document.querySelector(".progress-bar").style.width = `${percent}%`)
);
