/*
Exercise 3: Suppress Warnings for Unchecked Operations
Problem Statement: Create an ArrayList without generics and use #pragma warning disables to hide compilation warnings.
*/

using System.Collections;

namespace Annotations.Exercise3
{
    public static class Exercise3Runner
    {
        public static void Run()
        {
            Console.WriteLine(" Exercise 3: Suppress Warnings ");

            #pragma warning disable CS0618 // Disable warning for obsolete members (if any)
            #pragma warning disable CS8600 // Disable warning for possible null reference assignment
            
            // Using ArrayList (non-generic) 
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add(10);
            list.Add(true);

            foreach (var item in list)
            {
                Console.WriteLine($"Item: {item}");
            }

            #pragma warning restore CS0618
            #pragma warning restore CS8600
            
            Console.WriteLine("ArrayList used successfully without warnings.");
            Console.WriteLine();
        }
    }
}
