using System;

/*  6.  PROPERTIES */

/*  In C#, a property is a named member of a class, struct or interface. */
/*  "get" and "set" are default accessor methods for accessing properties. */

namespace Properties
{
    public class Person
    {
        private string name;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    public class Example
    {
        public static void Main()
        {
            Person person = new Person();
            // To use the get/set methods, do the following:
            person.Name = "Evan";               // set accessor
            Console.WriteLine(person.Name);     // get accessor
        }
    }
}