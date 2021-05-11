using System;

namespace variablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This part of output is for testing variable and primitive types");
            byte twenty = 20;
            int fourty = 40;
            float onepointtwo = 1.2f;
            double onepointthree = 1.3;
            char a = 'A';
            string word = "Word";

            Console.WriteLine(twenty);
            Console.WriteLine(fourty);
            Console.WriteLine(onepointtwo);
            Console.WriteLine(onepointthree);
            Console.WriteLine(a);
            Console.WriteLine(word);


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("This part of output is for testing var keyword");

            var one = 1;
            var name = "raman";
            var realNumber = 1.53;

            Console.WriteLine(one);
            Console.WriteLine(name);
            Console.WriteLine(realNumber);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("This part of output is for testing constant keyword");

            const double pi = 3.14;

            Console.WriteLine(pi);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Mission Accomplished...!");
            Console.WriteLine("");
            Console.WriteLine("");






        }
    }
}
