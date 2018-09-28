def printHello():
    print("Goodbye haha eat it maintainer")

printHello()

def printString(string):
    print(string)

printString("hey")

printString(1)

def sum(addend1, added2):
    return addend1 + added2

addend1 = 1
addend2 = 1
print(str(addend1) + " + " + str(addend2) + " = " + str(sum(addend1, addend2)))

# In Python, "null" is called "None"
# In Python there's no void, such functions just return None

printFunctionReturn = print()
print(printFunctionReturn == None)

# Use "keyword arguments" to name optional arguments

print("a", "b", "c", sep=", ", end=" Dis is the end\n")

# Use the "global" keyword to modify global-scope variables

def stealShip():
    global captain
    captain = "Look at me. I am the captain now."

captain = "Evan"
stealShip()
print(captain)