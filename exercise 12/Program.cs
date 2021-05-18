using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            // The list of numbers may include duplicates.
            // Display the unique numbers that the user has entered.

            var numbers = new List<int>();
            Console.WriteLine("Enter a number of type \"Quit\" to exit");

            while (true)
            {           
                string s = Console.ReadLine();
                string key1 = "quit";
                string key2 = "Quit";

                if(s==key1 || s==key2)
                {
                    break;
                }

                else
                {
                    int n = Convert.ToInt32(s);
                    numbers.Add(n);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            // to print original list
            Console.WriteLine("Original List : ");
            foreach (var number in numbers)
            {
                Console.Write(number + "\t");
            }

            // to print list without duplicate elements
            var uniqueNumbers = numbers.Distinct();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Unique Elements List : ");
            foreach (int number in uniqueNumbers)
            {
                Console.Write(number + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
