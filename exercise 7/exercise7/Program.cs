using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3- Write a program and ask the user to enter a number.
            // Compute the factorial of the number and print it on the console.
            // For example, if the user enters 5,
            // the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.


            int number;
            Console.WriteLine("Enter a Number");
            number = int.Parse(Console.ReadLine());
            int factorial = number;

            for(int i=number-1; i>0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("");
            Console.WriteLine(number+"!" + " = "+factorial);
            Console.WriteLine("");



        }
    }
}
