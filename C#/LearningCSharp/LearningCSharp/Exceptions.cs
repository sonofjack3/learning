using System;

/*  11. EXCEPTIONS */

/*  In C#, the Exception class is the base class for all exceptions.
    SystemExceptions are exceptions in the System namespace.
    User-defined exceptions should derive from ApplicationException.
*/

/*  As with Java, exceptions can be handled using try-catch blocks.
    Unlike Java, C# requires catch blocks to be placed in order of increasing generality (only the first matching block with execute).
    Also unlike Java, C# does not require an argument to a catch block (defaults to Exception class).
*/

namespace Exceptions
{
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException(int age) : base("Invalid age: " + age)
        {
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                throw new InvalidAgeException(age);
            }
        }
    }

    public class Example
    {
        public static void Main()
        {
            try
            {
                Person person = new Person("Evan", -1);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}