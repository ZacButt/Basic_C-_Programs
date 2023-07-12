using System;

namespace ConstructorAssignment
{
    class Program
    {
        // Create a constant variable
        const int MyConstant = 100;

        static void Main(string[] args)
        {
            // Create a variable using the var keyword
            var myVariable = "Hello, World!";

            // Chain two constructors together
            MyClass myObject = new MyClass();
            Console.WriteLine(myObject.Message);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    // Create a class with two constructors
    class MyClass
    {
        public string Message { get; }

        // Constructor with no parameters
        public MyClass()
        {
            Message = "Default constructor";
        }

        // Constructor with a parameter
        public MyClass(string message)
        {
            Message = message;
        }
    }
}