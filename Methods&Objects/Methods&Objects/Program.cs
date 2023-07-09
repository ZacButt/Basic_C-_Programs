using System;

namespace ConsoleApp
{
    // Define a class called Person
    class Person
    {
        // Define properties for FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Define a method called SayName
        public void SayName()
        {
            // Write the person's full name to the console
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Define a class called Employee that inherits from Person
    class Employee : Person
    {
        // Add a property called Id of type int
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 123
            };

            // Call the superclass method SayName on the Employee object
            employee.SayName();

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}