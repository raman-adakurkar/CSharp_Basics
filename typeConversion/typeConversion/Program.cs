using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversion

            Console.WriteLine("Implicit Type");
            byte b = 16;
            int i = b;
            Console.WriteLine(i);
            Console.WriteLine("");
            Console.WriteLine("");

            //Explicit Type Conversion

            Console.WriteLine("Explicit Type");
            int ii = 300;
            byte bb = (byte)ii;                     //data loss will occur here
            Console.WriteLine(bb);
            Console.WriteLine("");
            Console.WriteLine("");
            //Non Compatible Types

            Console.WriteLine("Non-Compatible Type");
            string s = "2708";

            int iii = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine(j);
            Console.WriteLine("");
            Console.WriteLine("");


        }
    }
}
