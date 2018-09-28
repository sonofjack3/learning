fun main(args : Array<String>) {
    print("How do you feel? ")
    print(whatShouldIDoToday(readLine()!!))
}

fun whatShouldIDoToday(mood : String,
                       weather : String = "sunny",
                       temperature : Int = 24) : String {
    return when {
        happySunny(mood, weather) -> "Go to the damn beach"
        sadSunny(mood, weather) -> "Read a damn book"
        else -> "Jerkit?"
    }
}

fun sadSunny(mood : String, weather : String) = mood == "sad" && weather == "sunny"

fun happySunny(mood : String, weather : String) = mood == "happy" && weather == "sunny"