using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {   //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers,
            //sort them and display the result on the console.

            var numbers = new List<int>();
            Console.WriteLine("Enter 5 Unique Numbers");

            while (numbers.Count()<5)
            {   
                int n = int.Parse(Console.ReadLine());

                    if (numbers.Contains(n))
                    {
                        Console.WriteLine("Number already exists, enter another number");
                    }

                    else
                    {
                        numbers.Add(n);
                    }
                            
            }

            numbers.Sort();
            Console.WriteLine();

            Console.Write("Sorted Order : ");
            foreach(var number in numbers)
            {
                Console.Write(number+"\t");
            }

            Console.WriteLine();
        }
    }
}
