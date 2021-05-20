using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase.
            // For example, if the user types: "number of students", display "NumberOfStudents".
            // Make sure that the program is not dependent on the input.
            // So, if the user types "NUMBER OF STUDENTS",
            // the program should still display "NumberOfStudents".

            Console.WriteLine("Enter a few words separated by a space");
            var s = Console.ReadLine();

            var words = s.Split(' ').Select(w => w.Substring(0, 1).ToUpper() + w.Substring(1).ToLower()); ;
            var result = string.Concat(words);

            Console.WriteLine(result);




        }
    }
}
