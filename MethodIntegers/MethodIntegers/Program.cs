using System;

namespace ConsoleApp
{
    public class Calculator
    {
        public int CalculateResult(int number1, int number2 = 0)
        {
            // Example math operation: multiply the two numbers
            int result = number1 * number2;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number (leave blank for no second number):");
            string secondNumberInput = Console.ReadLine();

            int secondNumber = 0;
            if (!string.IsNullOrEmpty(secondNumberInput))
            {
                secondNumber = Convert.ToInt32(secondNumberInput);
            }

            int result = calculator.CalculateResult(firstNumber, secondNumber);
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}