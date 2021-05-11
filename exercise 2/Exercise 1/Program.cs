
// 2- Write a program which takes two numbers from the console and displays the maximum of the two.


using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            string s1;
            string s2;

            Console.WriteLine("Enter First Number");
            s1 = Console.ReadLine();
            number1 = Convert.ToInt32(s1);

            Console.WriteLine("");

            Console.WriteLine("Enter Second Number");
            s2 = Console.ReadLine();
            number2 = Convert.ToInt32(s2);

            Console.WriteLine("");

            if(number1>number2)
            {
                Console.WriteLine(number1);
            }

            else
            {
                Console.WriteLine(number2);
            }


        }
    }
}
