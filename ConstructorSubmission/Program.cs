using System;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Corporation = "The Office"; //new constructor
            var newEmployee = new Employee("Johnny"); //using var to create new variable
            Console.WriteLine("This is {0}", Corporation); //calls constructor string
            Console.WriteLine(newEmployee.name + " is employed.");
        }
    }
}
