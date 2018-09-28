fun main(args : Array<String>) {
    val spices = listOf("curry", "pepper", "cayenne", "ginger", "red curry", "green curry", "red pepper", "chinnchilla", "charsparilla")
    val curries = spices.filter { it == "curry" }.sortedBy { it.length }
    println(curries)
    val spicesStartingWithCandEndingWithE = spices.filter { it[0] == 'c' && it.last() == 'e' }
    println(spicesStartingWithCandEndingWithE)
    val firstThreeSpicesStartingWithC = spices.filter { it.startsWith('c') }.take(3)
    println(firstThreeSpicesStartingWithC)
}
