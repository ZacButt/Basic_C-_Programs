using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            var student = new Student { Name = "John Doe", Age = 20 };
            context.Students.Add(student);
            context.SaveChanges();
        }

        Console.WriteLine("Student added to the database.");
        Console.ReadLine();
    }
}