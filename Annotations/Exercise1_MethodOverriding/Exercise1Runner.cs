/*
Exercise 1: Use Method Overriding Correctly
Runner class to demonstrate the functionality.
*/

namespace Annotations.Exercise1
{
    public static class Exercise1Runner
    {
        public static void Run()
        {
            Console.WriteLine("--- Exercise 1: Method Overriding ---");
            Animal myDog = new Dog(); // Polymorphism: Parent type holding child object
            myDog.MakeSound(); // Calls the overridden method in Dog
            Console.WriteLine();
        }
    }
}
