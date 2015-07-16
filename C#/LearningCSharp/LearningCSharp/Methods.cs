using System;

/*  4.  METHODS */

/*  The C# convention is to capitalize methods (Java uses lowercase by convention) */

/*  In C# and Java, method parameters that refer to an object are passed by reference.
    In C# and Java, primitive type variables (value types in C#) are passed by value.
*/

namespace Methods
{
    public class Example
    {
        public static void Main()
        {
            int x = 20;
            Console.WriteLine("Original value of x: {0}", x);

            /* In C#, value types can be passed by reference using the "ref" keyword. */
            Add1(10, ref x);
            Console.WriteLine("Value after adding: {0}", x);

            /* The "out" keyword is similar, but it ignores the original value (the variable must also be assigned to in the method) */
            int y = 20;
            Console.WriteLine("Original value of y: {0}", y);
            Add2(50, 50, out y);
            Console.WriteLine("Value after adding: {0}", y);
        }

        private static void Add1(int addend, ref int result)
        {
            result += addend;
            return;
        }

        private static void Add2(int addend1, int addend2, out int result)
        {
            result = addend1 + addend2;
            return;
        }
    }
}