/*
Exercise 4: Create a Custom Attribute and Use It
Runner class to retrieve attribute details using Reflection.
*/

using System.Reflection;

namespace Annotations.Exercise4
{
    public static class Exercise4Runner
    {
        public static void Run()
        {
            Console.WriteLine(" Exercise 4: Custom Attribute ");

            Type type = typeof(TaskManager);
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                // Check if the method has the TaskInfoAttribute
                var attribute = method.GetCustomAttribute<TaskInfoAttribute>();

                if (attribute != null)
                {
                    Console.WriteLine($"Method: {method.Name}");
                    Console.WriteLine($"  Priority: {attribute.Priority}");
                    Console.WriteLine($"  Assigned To: {attribute.AssignedTo}");
                }
            }
            Console.WriteLine();
        }
    }
}
