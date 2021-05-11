// 4- Your job is to write a program for a speed camera.
// For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
// Write a program that asks the user to enter the speed limit.
// Once set, the program asks for the speed of a car.
// If the user enters a value less than the speed limit, program should display Ok on the console.
// If the value is above the speed limit, the program should calculate the number of demerit points.
// For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
// If the number of demerit points is above 12, the program should display License Suspended.

using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float speedLimit;
            Console.WriteLine("Set Speed Limit");
            speedLimit = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float speedOfCar;
            Console.WriteLine("Enter Speed of Car");
            speedOfCar = float.Parse(Console.ReadLine());

            Console.WriteLine("");


            if (speedOfCar<speedLimit)
            {
                Console.WriteLine("Ok");
            }

            else
            {
                int count=0;
                float extraSpeed;
                int demerit_cutoff = 5;

                extraSpeed = speedOfCar - speedLimit;

                while (extraSpeed > demerit_cutoff)
                {
                    extraSpeed = extraSpeed - demerit_cutoff;
                    count++;
                    Console.WriteLine("1");
                }

                if(count>12)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Liscense Suspended");
                }
            }

            Console.WriteLine("");

        }
    }
}
