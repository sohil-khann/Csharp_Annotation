/*
Exercise 2: Use Obsolete Attribute to Mark an Old Method
Runner class to demonstrate the functionality.
*/

namespace Annotations.Exercise2
{
    public static class Exercise2Runner
    {
        public static void Run()
        {
            Console.WriteLine(" Exercise 2: Obsolete Attribute ");
            LegacyAPI api = new LegacyAPI();

            // Calling the old feature will generate a compiler warning
            api.OldFeature();

            api.NewFeature();
            Console.WriteLine();
        }
    }
}
