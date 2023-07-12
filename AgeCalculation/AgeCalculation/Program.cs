using System;

namespace AgeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    // Display error message for zero or negative numbers
                    Console.WriteLine("Invalid age. Age must be a positive number.");
                }
                else
                {
                    // Calculate the year the user was born
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;

                    // Display the year the user was born
                    Console.WriteLine("You were born in the year: " + birthYear);
                }
            }
            catch (FormatException)
            {
                // Display error message for invalid input format
                Console.WriteLine("Invalid input format. Age must be a valid number.");
            }
            catch (Exception ex)
            {
                // Display general error message for any other exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}