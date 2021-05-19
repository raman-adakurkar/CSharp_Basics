using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately;
            //otherwise, check to see if there are duplicates.
            //If so, display "Duplicate" on the console.

            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var s = Console.ReadLine();
            
            while(!String.IsNullOrWhiteSpace(s))
            {
                var elements = s.Split('-');
                var numbers = new List<int>();

                foreach (var element in elements)
                {
                    numbers.Add(int.Parse(element));
                }

                var originalCount = numbers.Count();

                var duplicateNumbers = numbers.Distinct();
                var duplicateCount = duplicateNumbers.Count();

                if(originalCount>duplicateCount)
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
                else
                {
                    break;
                }
            }


        }
    }
}
