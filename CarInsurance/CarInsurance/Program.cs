using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            bool qualified = CheckQualification(age, hasDUI, speedingTickets);

            Console.WriteLine("Qualified? " + qualified);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static bool CheckQualification(int age, bool hasDUI, int speedingTickets)
        {
            bool qualified = (age > 15) && !hasDUI && (speedingTickets <= 3);
            return qualified;
        }
    }
}
