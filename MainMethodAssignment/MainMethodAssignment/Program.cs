using System;


namespace ConsoleApp
{
    public class MathOperations
    {
        public int PerformOperation(int number)
        {
            // Example math operation: doubling the number
            return number * 2;
        }

        public int PerformOperation(decimal number)
        {
            // Example math operation: rounding the number to the nearest integer
            return (int)Math.Round(number);
        }

        public int PerformOperation(string numberString)
        {
            // Example math operation: adding 10 to the parsed integer value
            if (int.TryParse(numberString, out int number))
            {
                return number + 10;
            }
            else
            {
                Console.WriteLine("Invalid input. The provided string could not be converted to an integer.");
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            // Calling the PerformOperation method with an integer
            int result1 = math.PerformOperation(5);
            Console.WriteLine($"Result 1: {result1}");

            // Calling the PerformOperation method with a decimal
            int result2 = math.PerformOperation(3.14m);
            Console.WriteLine($"Result 2: {result2}");

            // Calling the PerformOperation method with a string
            int result3 = math.PerformOperation("20");
            Console.WriteLine($"Result 3: {result3}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
