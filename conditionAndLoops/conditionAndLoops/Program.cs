using System;

namespace conditionAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------");
            Console.WriteLine("Choose Option From Below\n------------------------------\n1. Print numbers from 1-10\n2. Print numbers from 11-20\n3. Print numbers from 21-30");

            Console.WriteLine("------------------------------");
            int key;
            string s;
            s = Console.ReadLine();

            key = Convert.ToInt32(s);

            
                if (key == 1 || key == 2 || key == 3)
                {
                    Console.WriteLine("");

                    switch (key)
                    {
                        case 1:
                            for (int i = 1; i <= 10; i++)
                            {

                                Console.Write(i + "\t");

                            }
                            Console.WriteLine("");
                            break;

                        case 2:
                            for (int i = 11; i <= 20; i++)
                            {

                                Console.Write(i + "\t");

                            }
                            Console.WriteLine("");
                            break;

                        case 3:
                            for (int i = 21; i <= 30; i++)
                            {

                                Console.Write(i + "\t");

                            }
                            Console.WriteLine("");
                            break;


                    }


                }




                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Option Selected");
                }

                Console.WriteLine("");


            
        }
        
        
    }
}
