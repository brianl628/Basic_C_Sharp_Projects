using System;

namespace MethodsAndObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee(); //employee class
            Person.FirstName = "Sample";
            Person.LastName = "Student";
            Person.SayName();
            Console.ReadLine();
        }
    }
}
