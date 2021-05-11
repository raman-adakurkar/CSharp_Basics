using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addOperationUsingClass
{
    public class Operation
    {
        public void Add(int a, int b)
        {
            int c;
            c = a + b;

            Console.WriteLine(c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Operation(); 
            result.Add(1,5);
        }
    }
}
