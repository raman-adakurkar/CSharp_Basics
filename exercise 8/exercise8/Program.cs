﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5- Write a program and ask the user to enter a series of numbers separated by comma.
            // Find the maximum of the numbers and display it on the console.
            // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.


            Console.WriteLine("Enter Numbers seperated by comma");

            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach(var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if(number>max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Max is : " + max);
        }
    }
}
