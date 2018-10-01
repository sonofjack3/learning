import io.reactivex.*;

public class App {
    public static void main(String[] args) {
        fakeUserInput().subscribe(line -> System.out.println(line));
    }

    public static Observable<Integer> fakeUserInput() {
        return Observable.just(10, 17, 3, 8);
    }
}
