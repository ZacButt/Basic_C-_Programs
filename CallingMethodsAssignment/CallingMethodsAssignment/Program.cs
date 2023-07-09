using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what number they want to perform math operations on
            Console.WriteLine("Enter a number to perform math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // Call each method in turn and display the returned integer
            int result1 = math.AddOne(userInput);
            Console.WriteLine($"AddOne result: {result1}");

            int result2 = math.MultiplyByTwo(userInput);
            Console.WriteLine($"MultiplyByTwo result: {result2}");

            int result3 = math.Square(userInput);
            Console.WriteLine($"Square result: {result3}");

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}