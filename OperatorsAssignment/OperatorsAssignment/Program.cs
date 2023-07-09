using System;

    static void Main(string[] args)
    {
        // Instantiate two Employee objects
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the Employee objects using the overloaded operators
        bool areEqual = emp1 == emp2;
        bool areNotEqual = emp1 != emp2;

        // Display the results
        Console.WriteLine($"emp1 == emp2: {areEqual}");
        Console.WriteLine($"emp1 != emp2: {areNotEqual}");

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }