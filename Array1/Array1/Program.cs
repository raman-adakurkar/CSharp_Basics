using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Declaration of Single Dimentional Array
            var numbers = new int[] { 2,7,0,8,1,6,0,2};

            //Displaying Single Dimentional Array
            Console.Write("Numbers : ");
            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write(numbers[i]+"\t");
            }
            Console.WriteLine("");

            //Length Property of Array
            Console.WriteLine("Length of Numbers : " + numbers.Length);

            //IndexOf Method(array_name, name of element)
            int index = Array.IndexOf(numbers, 6);
            Console.WriteLine("Index of 6 : " + index);

            // Clear(array_name, index from which to clear, how many elements to clear)
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("");

            Console.WriteLine("After clearing first two elements of Numbers Array...");
            Console.Write("Numbers : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+"\t");
            }
            Console.WriteLine("");

            // Copy(source_array_name, destination_array_name, number_of_elements_to_copy)
            var extraNumbers = new int[4];
            Array.Copy(numbers, extraNumbers, 4);

            Console.WriteLine("");
            Console.WriteLine("After copying 4 elements of Numbers to extraNumbers Array...");
            Console.Write("extraNumbers : ");
            for (int i = 0; i < extraNumbers.Length; i++)
            {
                Console.Write(extraNumbers[i] + "\t");
            }
            Console.WriteLine("");

            // Sort(array_name)
            Array.Sort(numbers);

            Console.WriteLine("");
            Console.WriteLine("After Sorting Numbers Array...");
            Console.Write("Numbers : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine("");

            // Reverse(array_name)
            Array.Reverse(numbers);

            Console.WriteLine("");
            Console.WriteLine("After Reversing Numbers Array...");
            Console.Write("Numbers : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine("");

        }
    }
}
