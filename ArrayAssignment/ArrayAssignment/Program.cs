using System;
using System.Collections.Generic;

namespace ArrayAndListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional Array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Durian", "Elderberry" };

            // Ask the user to select an index of the Array
            Console.WriteLine("Select an index of the Array (0 - 4):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the range of the Array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                string selectedString = stringArray[stringIndex];
                Console.WriteLine("Selected string: " + selectedString);
            }
            else
            {
                // Display a message for an invalid index
                Console.WriteLine("Invalid index selected!");
            }

            Console.WriteLine();

            // Create a one-dimensional Array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index of the Array
            Console.WriteLine("Select an index of the Array (0 - 4):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the range of the Array
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                int selectedInt = intArray[intIndex];
                Console.WriteLine("Selected integer: " + selectedInt);
            }
            else
            {
                // Display a message for an invalid index
                Console.WriteLine("Invalid index selected!");
            }

            Console.WriteLine();

            // Create a list of strings
            List<string> stringList = new List<string> { "Alice", "Bob", "Charlie", "Dave", "Eve" };

            // Ask the user to select an index of the list
            Console.WriteLine("Select an index of the list (0 - 4):");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the range of the list
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the content at the selected index
                string selectedContent = stringList[listIndex];
                Console.WriteLine("Selected content: " + selectedContent);
            }
            else
            {
                // Display a message for an invalid index
                Console.WriteLine("Invalid index selected!");
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
