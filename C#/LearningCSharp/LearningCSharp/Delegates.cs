using System;

/*  13. DELEGATES */

/*  An instance of the Delegate class can be used to choose a function to be called at run time. */
/*  Delegates are heavily used with events (see Events.cs) */

namespace Delegates
{
    public class Example
    {
        /* Delegates are declared using the following syntax */
        public delegate void Del1();
        /* This delegate can be used to reference any function that returns void and does not take any arguments */

        public static void Main()
        {
            Student student = new Student("Evan", 13, 8);

            /* The delegate declared above can be assigned as follows: */
            Del1 del = student.Birthday;
            /*  Invoke the delegate: */
            del();
            /*  Reassign the delegate: */
            del = student.Graduate;
            /*  Invoke the delgate again: */
            del();

            Console.WriteLine(student);
        }
    }

    public class Student
    {
        private string name;
        private int age;
        private int grade;

        public Student(string name, int age, int grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public void Birthday()
        {
            age++;
        }

        public void Graduate() 
        {
            grade++;
        }

        public override string ToString()
        {
            return name + " is " + age + " and is in grade " + grade;
        }
    }
}