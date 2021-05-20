using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the number of words.

            var path = @"C:\Users\raman\Desktop\raman.txt";
            var wordNumber = new List<string>(File.ReadAllText(path).Split(' '));
            Console.WriteLine(wordNumber.Count);
           
        }
    }
}
