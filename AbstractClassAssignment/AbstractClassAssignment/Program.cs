using System;

namespace ConsoleApp
{
    // Abstract class Person
    abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName()
        public abstract void SayName();
    }

    // Employee class inheriting from Person
    class Employee : Person
    {
        // Implementation of the SayName() method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee();

            // Set the first name and last name
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName() method on the object
            employee.SayName();

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}