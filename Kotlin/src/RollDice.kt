import java.util.*

/*
Create a lambda and assign it to rollDice, which returns a dice roll (number between 1 and 12).
Extend the lambda to take an argument indicating the number of sides of the dice used for the roll.
If you haven't done so, fix the lambda to return 0 if the number of sides passed in is 0.
Create a new variable, rollDice2, for this same lambda using the function type notation.
Create a function gamePlay() that takes a roll of the dice as an argument and prints it out.
Pass your rollDice2 function as an argument to gamePlay() to generate a dice roll every time gamePlay() is called.
 */

fun main(args : Array<String>) {
    println(rollDice(12))
    println(rollDice2(12))
    println(gamePlay(rollDice2))
}

val rollDice = {numSides : Int ->
    if (numSides == 0) 0
    else Random().nextInt(numSides) + 1
}

val rollDice2: (Int) -> Int = {numSides ->
    if (numSides == 0) 0
    else Random().nextInt(numSides) + 1
}

val rollDice3 = {numSides : Int ->
    if (numSides == 0) 0
    else Random().nextInt(numSides) + 1
}

fun gamePlay(diceRoll : (Int) -> Int) : Int {
    return diceRoll(6)
}