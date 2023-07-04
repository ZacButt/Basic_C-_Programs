using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // A one-dimensional array of strings
            string[] array = new string[3];

            // Ask the user to input some text
            Console.WriteLine("Enter text here:");

            // Loop to update each array element by appending the user's text
            for (int i = 0; i < array.Length; i++)
            {
                string userInput = Console.ReadLine();
                array[i] = array[i] + userInput;
            }

            // Loop to print each string in the array
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            // An infinite loop
            while (true)
            {
                // Fix the infinite loop by adding a condition to break the loop
                Console.WriteLine("This is an infinite loop. Enter 'exit' to break the loop:");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
            }

            // A loop with a "<" operator comparison
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // A loop with a "<=" operator comparison
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // A list of strings
            List<string> list = new List<string> { "apple", "banana", "orange", "grape" };

            // Ask the user to input text to search for in the list
            Console.WriteLine("Enter text to search in the list:");
            string searchText = Console.ReadLine();

            bool found = false;

            // Loop to iterate through the list and display matching indices
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(searchText))
                {
                    Console.WriteLine($"Match found at index {i}");
                    found = true;
                }
            }

            // Check if user input is not on the list
            if (!found)
            {
                Console.WriteLine("Input is not on the list.");
            }

            // A list of strings with duplicates
            List<string> duplicatesList = new List<string> { "apple", "banana", "orange", "apple", "grape" };

            // Ask the user to select text to search for in the list
            Console.WriteLine("Enter text to search in the duplicates list:");
            string searchTextDuplicates = Console.ReadLine();

            bool matchFound = false;

            // Loop to iterate through the list and display matching indices
            for (int i = 0; i < duplicatesList.Count; i++)
            {
                if (duplicatesList[i] == searchTextDuplicates)
                {
                    Console.WriteLine($"Match found at index {i}");
                    matchFound = true;
                }
            }

            // Check if user input is not on the list
            if (!matchFound)
            {
                Console.WriteLine("Input is not on the list.");
            }

            // A list of strings with duplicates
            List<string> stringsList = new List<string> { "A", "B", "C", "D", "C" };

            // Create a HashSet to track duplicates
            HashSet<string> uniqueSet = new HashSet<string>();

            // Foreach loop to evaluate each item in the list
            foreach (string item in stringsList)
            {
                if (uniqueSet.Contains(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    uniqueSet.Add(item);
                    Console.WriteLine($"{item} - this item is unique");
                }
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}