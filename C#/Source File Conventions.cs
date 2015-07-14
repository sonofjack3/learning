/*	In Java, classes can be grouped using the package keyword.
	In C#, the concept of namespaces is used to group logically related classes.
	This way, two classes with the same name might appear in two separate namespaces.
*/

using System.IO;
using Server = Microsoft.SqlServer.Server;

namespace Acme
{
	class Customer
    {

    }
}

/*	C# allows for multiple namespaces to be declared in a single file */

namespace AcmeAccounting
{
	public class GetDetails
    {
		//
    }
}

/*	Classes in other namespaces can be accessed using the fully qualified name for the class. 
	This can get unwieldy, so often we use the "using" keyword to specify an alias for the class (see line 7).
	The class can then be referenced using this alias (eg: Server.whatever)
*/

/*	Preprocessor directives can be used in C# source files (as in C and C++) */