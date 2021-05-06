import java.util.Random;

import io.reactivex.*;

public class App {
    public static void main(String[] args) {
        justExample().subscribe(line -> System.out.println(line));
        mapExample().subscribe(line -> System.out.println(line));
    }

    public static Observable<Integer> justExample() {
        /* An Observable represents a stream of data.
         * The just method takes in a list of data, and returns an Observable stream of that data.
         */
        return Observable.just(10, 17, 3, 8);
    }

    public static Observable<Integer> mapExample() {
        Random random = new Random();
        /**
         * The map method takes in a lambda, and will apply it to each element in the Observable's
         * stream, outputting a new Observable with a "mapped" stream of data.
         */
        return justExample().map(number -> number * random.nextInt(20));
    }
}
