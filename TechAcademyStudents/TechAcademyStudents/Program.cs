using System;

namespace TechAcademyStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Prompt and store the student's name
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            // Prompt and store the course name
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            // Prompt and store the page number
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Prompt and store if the student needs help
            Console.Write("Do you need help with anything? (true/false) ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Prompt and store positive experiences
            Console.Write("Were there any positive experiences you'd like to share? Please give specifics. ");
            string positiveExperiences = Console.ReadLine();

            // Prompt and store additional feedback
            Console.Write("Is there any other feedback you'd like to provide? Please be specific. ");
            string additionalFeedback = Console.ReadLine();

            // Prompt and store the number of hours studied
            Console.Write("How many hours did you study today? ");
            float studyHours = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
