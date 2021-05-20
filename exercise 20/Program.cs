using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the longest word in the file.

            var path = @"C:\Users\raman\Desktop\raman.txt";
            var words = new List<string>(File.ReadAllText(path).Split(' '));
            var prevlength = 0;
            var maxLength = 1;
            var word = new List<string>();

            foreach(var w in words)
            {
                prevlength = w.Count();
                if (prevlength > maxLength) 
                {
                    maxLength = prevlength;
                    word.Add(w);
                }
            }

            Console.WriteLine(word.Last());

        }
    }
}
