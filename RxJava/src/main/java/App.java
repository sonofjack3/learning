import io.reactivex.*;

public class App {
    public static void main(String[] args) {
        Observable.just("Hello world").subscribe(line -> System.out.println(line));
    }
}
