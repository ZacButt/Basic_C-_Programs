using System;
using System.IO

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for a number
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Log the number to a text file
                string filePath = @"C:\Users\Zac\Documents\number.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(input);
                }

                // Print the text file back to the user
                Console.WriteLine("Contents of the text file:");
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
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