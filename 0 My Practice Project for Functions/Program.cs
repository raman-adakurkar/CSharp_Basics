using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicing_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Open calculator\n" +
                    "2. Quit");
                Console.WriteLine("-----------------------");

                Console.Write("Enter your choice here : ");
                int choice1 = int.Parse(Console.ReadLine());
                
                if(choice1 == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Thank You...");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }

                Console.WriteLine();
                Console.WriteLine();

                switch (choice1)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("==========================================");
                            Console.WriteLine("|       Welcome to RLA's Calulator       |");
                            Console.WriteLine("==========================================");
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.Write("Enter First Number : ");
                            int a = int.Parse(Console.ReadLine());

                            Console.Write("Enter Second Number : ");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            int choice;
                            while (true)
                            {

                                Console.WriteLine("-----------------------");
                                Console.WriteLine("" +
                                "1. Addition\n" +
                                "2. Substraction\n" +
                                "3. Multiplication\n" +
                                "4. Division\n" +
                                "5. Exit");
                                Console.WriteLine("-----------------------");

                                Console.Write("Enter your choice here : ");
                                choice = int.Parse(Console.ReadLine());

                                if (choice == 5)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    break;
                                }

                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine();
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine("Addition is : " + Add(a, b));
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine();
                                        break;

                                    case 2:
                                        Console.WriteLine();
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine("Substraction is : " + Sub(a, b));
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine();
                                        break;

                                    case 3:
                                        Console.WriteLine();
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine("Multiplication is : " + Mul(a, b));
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine();
                                        break;

                                    case 4:
                                        Div(a, b);
                                        Console.WriteLine();
                                        break;
                                }
                            }
                        }

                        break;

                }

                
            }
        }

        public static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public static int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public static int Mul(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public static void Div(int a, int b)
        {

            int c;
            if(b==0)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine("Cannot Divide by Zero");
                Console.WriteLine("-----------------------");
                Console.WriteLine();

            }

            else
            {
                c = a / b;
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine("Division is : " + c);
                Console.WriteLine("-----------------------");
                Console.WriteLine();
            }

        }
    }
}
