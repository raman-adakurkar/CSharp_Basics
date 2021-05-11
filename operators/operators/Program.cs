using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);

            Console.WriteLine("");
            

            Console.WriteLine("a + b + c = " + (a+b+c));
            Console.WriteLine("a/b = " + ((float)a / (float)b));
            Console.WriteLine("a + b * c / a + d = " + (a + b * c / a + b));

            Console.WriteLine("");
            

            Console.WriteLine("a > b = " + (a > b));
            Console.WriteLine("a < b = " + (a < b));
            Console.WriteLine("!(a > b) = " + !(a > b));
            Console.WriteLine("a < b && b < c = " + ((a < b) && (b < c)));
            Console.WriteLine("a > b && b < c = " + ((a > b) && (b < c)));
            Console.WriteLine("a > b || b < c = " + ((a > b) || (b < c)));

            Console.WriteLine("");
        }
    }
}
