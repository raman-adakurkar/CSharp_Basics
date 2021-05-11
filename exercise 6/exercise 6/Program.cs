using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
			//2- Write a program and continuously ask the user to enter a number or "ok" to exit.
			//Calculate the sum of all the previously entered numbers and display it on the console.


			int input = 0;
			int total = 0;

			for (int i = 1; i > 0; i++)

			{
				Console.WriteLine("Enter a number OR Enter \"ok\" to exit");


				string test = Console.ReadLine().ToLower();

				if (test == "ok")
				{
					break;
				}
				else
				{
					input = int.Parse(test);
					total = total + input;
				}

				Console.WriteLine(total);
			}


		}
    }
}
