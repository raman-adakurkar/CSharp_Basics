using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            //display a message: "Consecutive";
            //otherwise, display "Not Consecutive".

            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var s = Console.ReadLine();
            var elements = s.Split('-');
            var numbers = new List<int>();
           
            foreach (var element in elements)
            {
                numbers.Add(int.Parse(element));
            }

            int count = numbers.Count();
            var measure = 0;

            for(int i=0; i<count-1; i++)
            {
                if((numbers[i+1]-1)==numbers[i])
                {
                    measure++;
                }

                else if((numbers[i+1] + 1) == numbers[i])
                {
                    measure++;
                }
            }

            if(measure == count-1)
            {
                Console.WriteLine();
                Console.WriteLine("Consecutive");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Not Consecutive");
                Console.WriteLine();
            }
        }
    }
}
