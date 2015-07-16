using System;
using System.Web.Services;

/*  12. ATTRIBUTES */

/*  Attributes are for adding declarative information about types.
    .NET Framework attributes can be used to take care of background stuff when calling a method or using a class.
*/

namespace Attributes
{
    public class Utilities : System.Web.Services.WebService
    {
        [System.Web.Services.WebMethod] // Attribute
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }

    public class Example
    {
        public static void Main()
        {
            Utilities utilities = new Utilities();
            Console.WriteLine(utilities.GetTime());
        }
    }
}