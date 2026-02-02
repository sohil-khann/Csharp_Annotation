/*
Exercise 1: Use Method Overriding Correctly
Problem Statement: Create a parent class Animal with a method MakeSound(). Then, create a Dog class that overrides this method using override.
*/

namespace Annotations.Exercise1
{
    public class Dog : Animal
    {
        // Using 'override' to provide a specific implementation of MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks: Woof! Woof!");
        }
    }
}
