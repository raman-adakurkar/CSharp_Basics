using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a time value in the 24-hour time format
            //e.g. 19:00). A valid time should be between 00:00 and 23:59.
            //If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            //If the user doesn't provide any values, consider it as invalid time.

            Console.WriteLine("Enter a time value in the 24-hour time format");
            var s = Console.ReadLine();
            var time = s.Split(':');
            var limit = new List<int>();

            var True = String.IsNullOrWhiteSpace(s);

            if(True==true)
            {
                Console.WriteLine("Invalid");
            }

            else
            {
                foreach (var t in time)
                {
                    limit.Add(int.Parse(t));
                }

                if (limit[0] >= 00 && limit[0] < 24 && limit[1] >= 00 && limit[0] < 60)
                {
                    Console.WriteLine("Ok");
                }

                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }
}
