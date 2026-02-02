/*
Exercise 4: Create a Custom Attribute and Use It
TaskManager class with methods annotated with TaskInfo.
*/

namespace Annotations.Exercise4
{
    public class TaskManager
    {
        [TaskInfo("High", "Sohil khan")]
        public void ProcessData()
        {
            Console.WriteLine("Processing data...");
        }

        [TaskInfo("Low", "Raj ")]
        public void GenerateReport()
        {
            Console.WriteLine("Generating report...");
        }
    }
}
