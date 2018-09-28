/*
Let's improve our SimpleSpice class so that we can have various spices with different levels of spiciness.

Create a new class, Spice.
Pass in a mandatory String argument for the name, and a String argument for the level of spiciness where the default value is mild for not spicy.
Add a variable, heat, to your class, with a getter that returns a numeric value for each type of spiciness.
Instead of the list of spices as Strings you used earlier, create a list of Spice objects and give each object a name and a spiciness level.
Add an init block that prints out the values for the object after it has been created. Create a spice.
Create a list of spices that are spicy or less than spicy. Hint: Use a filter and the heat property.
Because salt is a very common spice, create a helper function called makeSalt().
 */

class Spice(val name : String, val spiciness : String = "mild") {
    val heat : Int
        get() = when (spiciness) {
            "mild" -> 5
            else -> 0
        }

    init {
        println("Spice created with ${toString()}")
    }

    override fun toString() : String {
        return "name $name, spiciness $spiciness"
    }
}

fun makeSalt() = Spice("salt", "mild")

fun main(args : Array<String>) {
    val spices : List<Spice> = listOf(
            Spice("curry", "spicy"),
            Spice("cayenne", "hot"),
            makeSalt()
    )
    println(spices)
}