using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  3. FLOW CONTROL */

/*  if, else and else if are identical in both Java and C# */

/*  In Java, switch statements can only be used with ints.
    In C#, strings are allowed (NICE. REAL NICE)
*/

namespace FlowControl
{
    public class Example
    {
        public static void Main(string[] args)
        {
            switch (args[0])
            {
                case "copy":
                    Console.WriteLine("User selected copy");
                    break;
                case "move":
                    Console.WriteLine("User selected move");
                    break;
                case "del":
                    Console.WriteLine("User selected delete");
                    break;
                default:
                    Console.WriteLine("User did not provide args");
                    break;
            }
        }
    }
}