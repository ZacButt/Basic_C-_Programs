using System;

namespace ConsoleApp
{
    class Program
    {
        // Enum for the days of the week
        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week:");
                string userInput = Console.ReadLine();

                // Convert the user input to enum type
                DayOfWeek currentDay;
                Enum.TryParse(userInput, out currentDay);

                // Check if the input is a valid day of the week
                if (Enum.IsDefined(typeof(DayOfWeek), currentDay))
                {
                    Console.WriteLine("Valid day of the week entered!");
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}