using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // When you post a message on Facebook,
            // depending on the number of people who like your post,
            // Facebook displays different information.
            // If no one likes your post, it doesn't display anything.
            // If only one person likes your post, it displays: [Friend's Name] likes your post.
            // If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
            // If more than two people like your post,
            // it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.
            // Write a program and continuously ask the user to enter different names,
            // until the user presses Enter(without supplying a name).
            // Depending on the number of names provided,
            // display a message based on the above pattern.

            var a = 2;
            var names = new List<string>();

            while(a>1)
            {
                Console.Write("Enter Name : ");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                else
                {
                    names.Add(name);
                }
               
            }


            var count = names.Count();
            var likes = count - 2;

            if(count==0)
            {
                Console.WriteLine("Nobody Liked your Post");
            }
            else if (count ==1)
            {
                Console.WriteLine("{0} liked your post", names[0]);
            }
            else if (count==2)
            {
                Console.WriteLine("{0},{1} liked your post", names[0], names[1]);
            }

            else
            {
                Console.WriteLine("{0}, {1} and {2} peoples liked your post", names[0],  names[1], likes);
            }
            

        }
    }
}
