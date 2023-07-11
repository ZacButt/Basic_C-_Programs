using System;
using System.Collections.Generic;

namespace LambdaAssignment
{
    // Define the Employee class with Id, FirstName, and LastName properties
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Alex", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Davis" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Miller" },
                new Employee { Id = 7, FirstName = "Mike", LastName = "Wilson" },
                new Employee { Id = 8, FirstName = "Joe", LastName = "Thompson" },
                new Employee { Id = 9, FirstName = "Emily", LastName = "Clark" },
                new Employee { Id = 10, FirstName = "David", LastName = "Taylor" }
            };

            // Create a new list of employees with the first name "Joe" using a foreach loop
            List<Employee> joesList = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joesList.Add(emp);
                }
            }

            // Create a new list of employees with the first name "Joe" using a lambda expression
            List<Employee> joesListLambda = employees.FindAll(emp => emp.FirstName == "Joe");

            // Create a list of employees with an Id number greater than 5 using a lambda expression
            List<Employee> idGreaterThan5List = employees.FindAll(emp => emp.Id > 5);

            // Print the employees with the first name "Joe" from the foreach loop
            Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
            foreach (Employee emp in joesList)
            {
                Console.WriteLine($"Id: {emp.Id}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
            }
            Console.WriteLine();

            // Print the employees with the first name "Joe" from the lambda expression
            Console.WriteLine("Employees with the first name 'Joe' (lambda expression):");
            foreach (Employee emp in joesListLambda)
            {
                Console.WriteLine($"Id: {emp.Id}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
            }
            Console.WriteLine();

            // Print the employees with an Id number greater than 5 from the lambda expression
            Console.WriteLine("Employees with an Id greater than 5:");
            foreach (Employee emp in idGreaterThan5List)
            {
                Console.WriteLine($"Id: {emp.Id}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
            }
            Console.WriteLine();

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}