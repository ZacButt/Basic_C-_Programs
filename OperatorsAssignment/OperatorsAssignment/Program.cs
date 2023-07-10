using System;

// Define the Employee class
class Employee
{
    // Properties of the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects based on their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if the Id properties of the two employees are equal
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator by using the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Negate the result of the "==" operator
        return !(emp1 == emp2);
    }
}

class Program
{
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
}