namespace PolymorphismProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuittable and assign an instance of the Employee class
            IQuittable quittable = new Employee();

            // Call the Quit() method on the IQuittable object
            quittable.Quit();

            // Rest of your code...
        }
    }
}