using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            double rate1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            double hours1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            double rate2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            double hours2 = Convert.ToDouble(Console.ReadLine());

            double salary1 = rate1 * hours1 * 52; // Calculate annual salary for Person 1
            double salary2 = rate2 * hours2 * 52; // Calculate annual salary for Person 2

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1.ToString("N0")); // Display salary for Person 1 with thousands separator

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2.ToString("N0")); // Display salary for Person 2 with thousands separator

            bool person1EarnsMore = salary1 > salary2; // Compare salaries

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1EarnsMore);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
