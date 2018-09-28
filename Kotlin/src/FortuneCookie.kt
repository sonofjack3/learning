import java.util.*

fun main(args : Array<String>) {
    val userNumber = getNumberFromUser()
    println(getFortuneCookie(userNumber))
}

fun getNumberFromUser(): Int {
    print("Enter a number: ")
    return readLine()?.toIntOrNull() ?: 0
}

fun getFortuneCookie(userNumber : Int) : String {
    var randomGenerator : Random = Random()
    val fortunes : List<String> = listOf(
        "You will die",
        "You will maybe die",
        "You will most likely die",
        "You will have a great, great day",
        "You will have a luvly treat",
        "Everyone you know hates your shirt",
        "Those warts on your dick aren't going to go away",
        "Take it from me: never ask for an extra fork at a Chinese restaurant",
        "I've never seen penguins and puffins in the same place at the same time, have you?",
        "Drinking soap gives you super powers")
    val fortuneNumber = if (userNumber + 1 <= fortunes.size) userNumber else randomGenerator.nextInt(fortunes.size)
    return fortunes.get(fortuneNumber)
}