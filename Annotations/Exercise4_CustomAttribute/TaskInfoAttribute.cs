/*
Exercise 4: Create a Custom Attribute and Use It
Problem Statement: Create a custom attribute TaskInfo to mark tasks with priority and assigned person.
Steps to Follow:
1. Define an attribute TaskInfo with fields Priority and AssignedTo.
2. Apply this attribute to a method in TaskManager class.
3. Retrieve the attribute details using Reflection.
*/

using System;

namespace Annotations.Exercise4
{
    // Custom attributes must inherit from System.Attribute
    [AttributeUsage(AttributeTargets.Method)] // Restrict usage to methods
    public class TaskInfoAttribute : Attribute
    {
        public string Priority { get; set; }
        public string AssignedTo { get; set; }

        public TaskInfoAttribute(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }
}
