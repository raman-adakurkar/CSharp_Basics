using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to supply a list of
            //comma separated numbers(e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List"
            //and ask the user to re-try; otherwise,
            //display the 3 smallest numbers in the list.

            var numbers = new List<int>();

            var s = Console.ReadLine();
            string[] elements;
            elements = s.Split(',');


            foreach (var e in elements)
            {
                numbers.Add(int.Parse(e));
            }


            if(String.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Invalid list");
            }

            else if(elements.Length < 5)
            {
                Console.WriteLine("Invalid list");
            }


            else
            {
                numbers.Sort();
                var uniqueNumbers = numbers.Distinct();
                var minNumbers = uniqueNumbers.Take(3);

                Console.Write("Min : ");
                foreach(var m in minNumbers)
                {
                    Console.Write(m + "\t");
                }

                Console.WriteLine();

            }

            
        }
    }
}
