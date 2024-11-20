using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Using for loop
            // Ask the user for input
            //Console.Write("Enter the number of terms for the Fibonacci series: ");
            //int N = Convert.ToInt32(Console.ReadLine());

            //// Initial two terms of the Fibonacci series
            //int firstTerm = 0, secondTerm = 1;

            //Console.WriteLine("Fibonacci Series:");

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.Write(firstTerm + " ");

            //    // Calculate the next term
            //    int nextTerm = firstTerm + secondTerm;

            //    // Update the terms
            //    firstTerm = secondTerm;
            //    secondTerm = nextTerm;
            //}

            //Using while loop
            //Input: No of Terms
            Console.WriteLine("Enter the number of terms:");
            int number = Convert.ToInt32(Console.ReadLine());

            //Initial two terms of series
            int first_num = 0;
            int second_num = 1;

            //Initializing counter variable
            int i = 0;

            Console.WriteLine("Fabonacci Series:");
            while (i <= number) 
            {
                //Printing term
                Console.Write(first_num + " ");

                //Calculating next term
                int next_num = first_num + second_num;

                //Updating terms
                first_num = second_num;
                second_num = next_num;

                //increment
                i++;
            }
            Console.ReadLine();
        }
    }
}
