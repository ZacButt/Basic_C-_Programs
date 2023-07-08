using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a list of integers
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Ask the user for a number to divide each number in the list by
                Console.WriteLine("Enter a number to divide each number in the list by:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                // Loop through each integer in the list, divide it by the user's input, and display the result
                for (int i = 0; i < numbers.Count; i++)
                {
                    int result = numbers[i] / divisor;
                    Console.WriteLine($"Result for number at index {i}: {result}");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued with execution.");
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}