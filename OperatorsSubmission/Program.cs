using System;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee() { FirstName = "John", LastName = "Smith", ID = 1 }; //instantiate
            Employee Employee2 = new Employee() { FirstName = "Mary", LastName = "Saunders", ID = 2 };
            Console.WriteLine(Employee1 == Employee2);
            Console.ReadLine(); //Pause application
        }
    }
}
