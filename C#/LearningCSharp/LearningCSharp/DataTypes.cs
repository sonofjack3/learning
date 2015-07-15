using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2. DATA TYPES */

/*	Classes in Java and C# can be thought of as compound data types, with fields, methods and events
	In C#, a struct is a stack-allocated compound data type that does not support inheritance.
	In most other respects, structs are very similar to classes, but are more lightweight than classes (better performance).
*/

namespace DataTypes
{
    public class Example
    {
        /*  C# allows for contants using the "const" keyword (same as "final" keyword in Java).
            The "readonly" keyword allows a variable's value to never be changed.
            Readonly variables are useful when modules that share data need to be compiled separately.
        */
        const int MAX = 20;
        readonly string WHATEVER = "Whatever";

        public enum Color
        {
            Green,      //defaults to 0
            Orange,     //defaults to 1
            Red,        //defaults to 2
            Blue        //defaults to 3
        }

        [STAThread]
        static void Main()
        {
            PrimitiveDataTypes();

            EnumeratedTypes();

            Strings();

            Conversions();

            VariableTypes();
        }

        private static void PrimitiveDataTypes()
        {
            /*  C# provides all data types available in Java and a few more.
                In Java, each primitive data type is wrapped in a core class (eg: double is wrapped by Double).
                In C#, all primitive data types already are objects in the System namespace (eg: int is the alias for System.Int32).
                It is thus possible to call methods on a primitive data type, like so:
            */
            int i = 10;
            object o = i;
            Console.WriteLine(o.ToString());
        }

        private static void EnumeratedTypes()
        {
            /*  C# supports enumerated types */

            Console.WriteLine("Possible colors: ");

            //Use the Enum.GetNames method to return a string array of named constants for an enum
            foreach (string s in Enum.GetNames(typeof(Color)))
            {
                Console.WriteLine(s);
            }

            Color currentColor = Color.Orange;

            Console.WriteLine("Current color is {0}", currentColor);
            Console.WriteLine("Current color value is {0}", (int)currentColor);
        }

        private static void Strings()
        {
            /*  Strings in Java and C# are immutable.
                C# Strings can be compared using the == and != operators (NICE).
            */

            if ("ECH" == "ECH")
            {
                Console.WriteLine("Those two are the same!");
            }

            /*  String literals can be used to avoid having to escape characters (precede with the @ symbol) */

            string line = @"Well,    I'm not really sure about that \m/";
            Console.WriteLine(line);
        }

        private static void Conversions()
        {
            /*  Implicit conversions are supported in C# */
            int a = 5;
            long b = a;
            /*  Explicit conversions are also supported */
            long c = 5483;
            int d = (int)c;
        }

        private static void VariableTypes()
        {
            /*  C# supports two kinds of variable types:
                1. Value types - built-in primitive types and user-defined structs
                2. Reference types - Classes and other complex data types (variables of such types contain a reference to an instance)
            */

            int i = 10;
            int j = 20;
            // Since int is a value type, there is no connection between variables if one is assigned to another (assign-by-value) */ 
            int k = i;
            // A change made to i will not affect k
            i = 30;
            Console.WriteLine(i.ToString());
            Console.WriteLine(k.ToString());

            // Reference types on the other hand, point to memory addresses
            Person person1 = new Person("Evan");
            Person person2 = person1;
            // person2 now points to the same memory address as person1, so a change made to either affects the other
            person2.SetName("Riley");
            Console.WriteLine(person1.ToString());

            /*  The process of converting a value type to a reference type is called "boxing".
                The process of converting a reference type to a value type is called "unboxing".
                In Java, this is akin to creating a wrapper class for a primitive data type and converting.
            */
        }
    }

    public class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        override public string ToString()
        {
            return name;
        }
    }
}