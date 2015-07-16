using System;

/*  9. INHERITANCE AND DERIVED CLASSES */

/*  Inheritance and interface implementation are both defined by the ":" operator in C#.
    Like in Java, classes in C# cannot inherit from more than one class, but can implement multiple interfaces.
*/

namespace InheritanceAndImplementation
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "Anonymous";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /*  A method that is to be overriden in a derived class must be declared as virtual, abstract or override */
        public virtual void Birthday()
        {
            Age++;
        }
    }

    public class Student : Person
    {
        private int grade;

        /*  Constructors can be selected using the ": base (properties)" syntax (similar to "super" in Java) */

        public Student() : base ()
        {
            grade = 0;
        }

        public Student(string name, int age, int grade) : base (name, age)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override void Birthday()
        {
            base.Birthday();
            Console.WriteLine("Happy {0}th Birthday {1}!", Age, Name);
        }
    }

    public class Example
    {
        public static void Main()
        {
            Student student = new Student("Jim", 17, 12);
            Console.WriteLine("{0} is {1} years old and is in grade {2}.", student.Name, student.Age, student.Grade);
            student.Birthday();
        }
    }
}