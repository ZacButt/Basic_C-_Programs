using System;
using System.Text;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "!";

            string concatenatedString = str1 + " " + str2 + str3;
            Console.WriteLine("Concatenated String: " + concatenatedString);
            Console.WriteLine();

            // Converting a string to uppercase
            string lowercaseString = "this is a lowercase string";
            string uppercaseString = lowercaseString.ToUpper();
            Console.WriteLine("Uppercase String: " + uppercaseString);
            Console.WriteLine();

            // Using StringBuilder to build a paragraph of text
            StringBuilder paragraphBuilder = new StringBuilder();

            paragraphBuilder.Append("This is the first sentence. ");
            paragraphBuilder.Append("This is the second sentence. ");
            paragraphBuilder.AppendLine("This is the third sentence, added using AppendLine.");

            string paragraph = paragraphBuilder.ToString();
            Console.WriteLine("Paragraph:\n" + paragraph);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
