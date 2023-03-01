using System;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee() //new class
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            Person.SayName();
            Console.ReadLine();
        }
    }
}
