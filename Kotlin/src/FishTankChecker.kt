import kotlin.test.assertFalse
import kotlin.test.assertTrue

/* Typically, a tank with decorations can contain a total length of fish (in inches) less than or equal to 80% of the tank size (in gallons). A tank without decorations can contain a total length of fish up to 100% of the tank size.

For example:
A 10 gallon tank with decorations can hold up to 8 inches of fish, for example 4 x 2-inch-long fish.
A 20 gallon tank without decorations can hold up to 20 inches of fish, for example 6 x 1-inch-long fish and 2 x 2-inch-long fish.
fitMoreFish function
Create a function that takes these arguments:

tankSize (in gallons)
currentFish (a list of Ints representing the length of each fish currently in the tank)
fishSize (the length of the new fish we want to add to the tank)
hasDecorations (true if the the tank has decorations, false if not)

canAddFish(10.0, listOf(3,3,3)) ---> false
canAddFish(8.0, listOf(2,2,2), hasDecorations = false) ---> true
canAddFish(9.0, listOf(1,1,3), 3) ---> false
canAddFish(10.0, listOf(), 7, true) ---> true
*/

fun main(args : Array<String>) {
    assertFalse { canFitMoreFish(10.0, listOf(3, 3, 3)) }
    assertTrue { canFitMoreFish(8.0, listOf(2, 2, 2), tankHasDecorations = false) }
    assertFalse { canFitMoreFish(9.0, listOf(1, 1, 3), 3) }
    assertTrue { canFitMoreFish(10.0, listOf(), 7, true) }
}

fun canFitMoreFish(tankSizeInGallons : Double,
                   currentLengthsOfFish : List<Int>,
                   newFishSize : Int = 2,
                   tankHasDecorations : Boolean = true) : Boolean {
    val totalLengthOfAllFish = (currentLengthsOfFish.sum() + newFishSize).toDouble()

    return if (tankHasDecorations) {
        totalLengthOfAllFish <= (0.80 * tankSizeInGallons)
    } else {
        totalLengthOfAllFish <= tankSizeInGallons
    }
}