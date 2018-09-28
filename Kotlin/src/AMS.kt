import java.util.*

fun main(args : Array<String>) {
    println("${if (args[0].toInt() < 12) "Good morning" else "Good night"}")
}

fun whatDayIsItToday() {
    print("What day is it today? ")
    val dayOfWeek = Calendar.getInstance().get(Calendar.DAY_OF_WEEK)
    println(when (dayOfWeek) {
        1 -> "Laundry"
        2 -> "Monday"
        3 -> "Tuesday"
        4 -> "Wednesday"
        5 -> "Thursday"
        6 -> "Laundry Picante"
        7 -> "Karaoke"
        else -> "Time paradox?"})
}