using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter their name.
            //Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine();

            char[] arrName = name.ToCharArray();

            Array.Reverse(arrName);
            foreach (var names in arrName)
            {
                Console.Write(names);
            }
            Console.WriteLine();

            
        }
    }
}
