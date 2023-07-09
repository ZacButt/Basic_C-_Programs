using System;

namespace ConsoleApp
{
    public class ArithmeticHelper
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result: {result}");
        }

        public void ProcessOutput(int input, out int output)
        {
            output = input * 3;
        }

        public void OverloadMethod(string message)
        {
            Console.WriteLine($"OverloadMethod with string parameter: {message}");
        }

        public void OverloadMethod(int number)
        {
            Console.WriteLine($"OverloadMethod with int parameter: {number}");
        }
    }

    static class HelperUtility
    {
        public static void PerformStaticAction()
        {
            Console.WriteLine("This is a static method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticHelper helper = new ArithmeticHelper();

            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            helper.DivideByTwo(userInput);

            int outputParam;
            helper.ProcessOutput(userInput, out outputParam);
            Console.WriteLine($"Output Parameter: {outputParam}");

            helper.OverloadMethod("Hello");
            helper.OverloadMethod(123);

            HelperUtility.PerformStaticAction();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}