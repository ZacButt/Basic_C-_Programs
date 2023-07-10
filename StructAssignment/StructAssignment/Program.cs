using System;

namespace ConsoleApp
{
    // Define the Number struct with a decimal property called "Amount"
    struct Number
    {
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Number
            Number numberObject;

            // Assign a value to the Amount property of the numberObject
            numberObject.Amount = 10.5m;

            // Print the value of the Amount property to the console
            Console.WriteLine("Amount: " + numberObject.Amount);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}