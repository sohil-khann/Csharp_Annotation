/*
Exercise 2: Use Obsolete Attribute to Mark an Old Method
Problem Statement: Create a class LegacyAPI with an old method OldFeature(), which should not be used anymore. Instead, introduce a new method NewFeature().
Steps to Follow:
1. Define a class LegacyAPI.
2. Mark OldFeature() as [Obsolete].
3. Call both methods and observe the warning.
*/

using System;

namespace Annotations.Exercise2
{
    public class LegacyAPI
    {
        // Marking the method as obsolete. The second parameter can provide a message.
        [Obsolete("OldFeature is deprecated, please use NewFeature instead.")]
        public void OldFeature()
        {
            Console.WriteLine("Executing the old feature...");
        }

        public void NewFeature()
        {
            Console.WriteLine("Executing the new and improved feature!");
        }
    }
}
