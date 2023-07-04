using System;

namespace BooleanComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            Console.WriteLine("Boolean comparison using a while statement:");

            int counter = 1;

            // The while loop will continue as long as the counter is less than or equal to 5
            while (counter <= 5)
            {
                Console.WriteLine("Counter: " + counter);
                counter++; // Increment the counter by 1
            }

            Console.WriteLine();

            // Boolean comparison using a do-while statement
            Console.WriteLine("Boolean comparison using a do-while statement:");

            int number = 10;

            // The do-while loop will execute the code block at least once before checking the condition
            do
            {
                Console.WriteLine("Number: " + number);
                number--; // Decrement the number by 1
            }
            while (number >= 5);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
