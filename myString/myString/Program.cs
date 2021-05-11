using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myString
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Raman";
            var lastName = "Adakurkar";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);


            var numbers = new int[3] { 1, 2, 3 };
            var number = string.Join(",", numbers);

            Console.WriteLine(number);

            var name = "Reema";
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[4]);

            var path = @"c:\project\project1
c:\project2\project3";
            Console.WriteLine(path);
        }
    }
}
