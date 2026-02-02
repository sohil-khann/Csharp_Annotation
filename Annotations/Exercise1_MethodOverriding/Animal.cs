/*
Exercise 1: Use Method Overriding Correctly
Problem Statement: Create a parent class Animal with a method MakeSound(). Then, create a Dog class that overrides this method using override.
Steps to Follow:
1. Define a MakeSound() method in the Animal class.
2. Override it in the Dog class with override.
3. Instantiate Dog and call MakeSound().
*/

namespace Annotations.Exercise1
{
    public class Animal
    {
        // Virtual method allows subclasses to override it
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a generic sound.");
        }
    }
}
