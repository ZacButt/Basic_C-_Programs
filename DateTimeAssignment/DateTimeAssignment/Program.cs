using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Print the current date and time to the console
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("Current date and time: " + currentDateTime);

                // Ask the user for a number
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Parse the user input as an integer
                int hours = int.Parse(input);

                // Calculate the future date and time
                DateTime futureDateTime = currentDateTime.AddHours(hours);
                Console.WriteLine("In " + hours + " hours, the time will be: " + futureDateTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}