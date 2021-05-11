using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating New List
            var numbers = new List<int>() { 1,2,3,4};

            Console.WriteLine("Original List : ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Adding New Element to list
            numbers.Add(5);

            Console.WriteLine("After adding element 5");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Removing Element From List
            numbers.Remove(3);

            Console.WriteLine("After Removing element 3");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // To add multiple elements in the list
            numbers.AddRange(new List< int >(){ 6,7,8});

            Console.WriteLine("After adding New List {6,7,8}");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Removing element at particular position
            numbers.RemoveAt(1);

            Console.WriteLine("After removing element from index 1");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // To find index of an element
            var index = numbers.IndexOf(6);
            Console.WriteLine("Index of 6 is : " + index);
            Console.WriteLine();

            // To check if a particular element is present in the list or not
            var check = numbers.Contains(7);
            Console.Write("List contains 7 : ");
            Console.WriteLine(check);
            Console.WriteLine();

            // To find out how many numbers are there in the list
            int count = numbers.Count();
            Console.WriteLine("Number of Elements in the list is : " + count);
            Console.WriteLine();
            

        }
    }
}
