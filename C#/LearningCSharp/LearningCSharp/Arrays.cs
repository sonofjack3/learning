using System;

/*  8. ARRAYS */

namespace Arrays
{
    public class Example
    {
        public static void Main()
        {
            /*  One-dimensional arrays are created in C# with the same syntax as Java */
            int[] arr1;
            arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int[] arr3 = new int[5];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = i + 1;
            }

            /*  Jagged arrays are non-rectangular arrays in which each row contains a different number of columns */
            int[][] jaggArr = new int[2][];
            jaggArr[0] = new int[5];    // first row contains 5 columns
            jaggArr[1] = new int[3];    // second row contains 5 columns

            /*  Multi-dimensional arrays are created using the following syntax: */
            int[,] arr2D;   // 2D array declaration
            int[,,,] arr4D; // 4D array declaration

            arr2D = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } };  // 2D array with 5 rows, 4 columns
            arr4D = new int[4, 4, 4, 4]; // A tesseract

            /*  In the .NET framework, arrays are implemented instances of the Array class.
                This class provides several useful methods including Sort and Reverse.
            */

            int[] arr4 = new int[5] { 2, 3, 5, 4, 1 };
            Array.Reverse(arr4);
            Console.Write("Reversed: ");
            foreach(int i in arr4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Sort(arr4);
            Console.Write("Sorted: ");
            foreach(int i in arr4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}