using System;

/*  5. USING AN INDETERMINATE NUMBER OF PARAMETERS */

/*  In C#, an indeterminate number of parameters can be specified using the "params" keyword.
    The "params" keyword must come last.
*/

namespace IndeterminateParameters
{
    public class Example
    {
        public static void Main()
        {
            PrintIntList("First list", 1, 2, 3, 4, 5);
            PrintIntList("Second list", 1, 2, 3, 4, 5, 6, 7, 8, 9);

            /* The params keyword works with any type... */
            PrintStringList("Third list", "Green", "Blue", "White");
            PrintStringList("Fourth list", "Evan", "Riley", "Terry", "Judy");
        }

        /* Prints an integer array of indeterminate size */
        private static void PrintIntList(string listTitle, params int[] values)
        {
            Console.Write("{0}: ", listTitle);
            foreach (int i in values)
            {
                Console.Write(" {0}", i);
            }
            Console.Write("\n");
        }

        /* Prints a string array of indeterminate size */
        private static void PrintStringList(string listTitle, params string[] values)
        {
            Console.Write("{0}: ", listTitle);
            foreach (string s in values)
            {
                Console.Write(" {0}", s);
            }
            Console.Write("\n");
        }
    }
}