using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************************************************************************/
/* Program Name:     Chp20Ex9.cs                                         */
/* Date:             11/12/2015                                          */
/* Programmer:       Joshua J. Evers                                     */
/* Class:            CSCI 234                                            */
/*                                                                       */
/* Program Description: This program uses the books provided code.       */
/*                      then improves upon it by creating a non-generic  */
/*                      override method for the specific string array    */
/*                      that is formatted in tabular with 4 columns      */
/*                                                                       */
/* Input:	No input for this application. Everything is hard coded      */
/*                                                                       */
/* Output:	Outputs the same data as the book, while also displaying     */
/*                 the new string method with the given data values      */
/* Givens:	"one", "twoooooooooooooooo", "three", "four", "five", "six", */
/*                 "seven", "eight" and all additional data from book    */
/*                               from the input)                         */
/*                                                                       */
/* Testing Data: Started the program, gave correct output in the correct */
/*                        tabular format.                                */
/*                        **Success                                      */
/*************************************************************************/

namespace genericOverride
{
    class Chp20Ex9
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7};
            char[] charArray = {'H','E','L','L','O'};
            string[] strArray = { "one", "twoooooooooooooooo", "three", "four", "five", "six", "seven", "eight" };
            Console.WriteLine("Array intArray contains:");
            DisplayArray(intArray);
            Console.WriteLine("Array doubleArray contains:");
            DisplayArray(doubleArray);
            Console.WriteLine("Array charArray contains:");
            DisplayArray(charArray);
            Console.WriteLine("Array strArray contains:");
            DisplayArray(strArray);

        }//End Main
        private static void DisplayArray< T >( T[] inputArray )
        {
            foreach (T element in inputArray)
                Console.Write(element + " ");

            Console.WriteLine("\n");
        }//End DisplayArray

        //Overridden DisplaysArray method, nongeneric takes in a string array
        //If string array is passed, uses this method and writes strings in
        //tabular format, using 4 columns and as many rows as neccessary. 
        private static void DisplayArray(string[] strings)
        {
            int four = 4;
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(strings[i]);
                int columns = (strings[i].Length - 1) / 10 + 1;
                four = four - columns;
                columns = (columns * 10) - strings[i].Length;
                for (int j = columns; j > 0; j-- )
                {
                    Console.Write(" ");
                }
                if(four <= 0)
                {
                    Console.WriteLine();
                    four = 4;
                }
            }
            Console.WriteLine();
        }//End DisplayArray OVERRIDE
    }//End Class Chp20Ex9
}//End Application
