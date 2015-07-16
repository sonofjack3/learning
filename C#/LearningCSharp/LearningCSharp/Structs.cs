using System;

/*  7. STRUCTS */

/*  Structs can be thought of as lightweight classes */
/*  Structs are mostly used to encapsulate groups of related fields */
/*  Structs are value types and can thus be allocated slightly more efficiently. */
/*  Structs cannot be abstract and don't support inheritance */

namespace Structs
{
    public struct Person
    {
        public int ID;
        public string Name;

        public Person(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }

    public class Example
    {
        public static void Main()
        {
            Person person = new Person();   //using default constructor

            Console.WriteLine("Struct values before initialization:");
            Console.WriteLine("ID = {0}, Name = {1}", person.ID, person.Name);
            Console.WriteLine();

            person.ID = 2134;
            person.Name = "Evan";

            Console.WriteLine("Struct values after initialization:");
            Console.WriteLine("ID = {0}, Name = {1}", person.ID, person.Name);
        }
    }
}