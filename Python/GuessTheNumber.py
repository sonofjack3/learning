import random

lowRange = 1
highRange = 100
randomNumber = random.randint(lowRange, highRange)

def verifyInput(userGuess):
    global randomNumber
    if userGuess < randomNumber:
        print("Too low")
        return False
    elif userGuess > randomNumber:
        print("Too high")
        return False
    else: 
        print("Yeah maaaaaan")
        return True   

isGuessCorrect = False
userGuess = 0
numGuessLeft = 10
while isGuessCorrect is False and numGuessLeft > 0:
    try:
        print("Guess da number (between " + str(lowRange) + " and " + str(highRange) + "). " + str(numGuessLeft) + " guesses left.")
        userGuess = int(input())

        numGuessLeft -= 1

        isGuessCorrect = verifyInput(userGuess)
    except ValueError:
        print("Invalid input. Try again.")

if (numGuessLeft == 0):
    print("Outta guesses. The number was " + str(randomNumber) + ".")


