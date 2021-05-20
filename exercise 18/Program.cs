using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter an English word.
            //Count the number of vowels (a, e, o, u, i) in the word.
            //So, if the user enters "inadequate", the program should display 6 on the console.

            Console.Write("Enter an English Word : ");
            var word = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var vowelsCount = 0;

            foreach (var character in word)
            {
                if (vowels.Contains(character))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);



        }
    }
}
