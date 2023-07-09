using System;

namespace ConsoleApp
{
    public class MathHelper
    {
        public void PerformMathOperation(int number1, int number2)
        {
            // Example math operation: subtracting number1 from number2
            int result = number2 - number1;
            Console.WriteLine($"The result is: {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();

            // Call the method, passing in two numbers
            mathHelper.PerformMathOperation(5, 3);

            // Call the method, specifying the parameters by name
            mathHelper.PerformMathOperation(number1: 10, number2: 7);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}