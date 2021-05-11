using System;

namespace firstClassProgram
{
    public class Person
    {
        public string firstname;
        public string lastname;
        public int age;

        public void Introduce()
        {
            Console.WriteLine("Name : " + firstname + ", Surname : " + lastname + ", Age : " + age);
        }
    }
}
