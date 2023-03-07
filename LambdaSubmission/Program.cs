using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Employee1 = new Employee() //Creating employee classes
            {
                ID = 1,
                firstName = "Adam",
                lastName = "Smith"
            };
            Employee Employee2 = new Employee()
            {
                ID = 2,
                firstName = "Joe",
                lastName = "Sanders"
            };
            Employee Employee3 = new Employee()
            {
                ID = 3,
                firstName = "Melissa",
                lastName = "Spears"
            };
            Employee Employee4 = new Employee()
            {
                ID = 4,
                firstName = "Joe",
                lastName = "Johnson"
            };
            Employee Employee5 = new Employee()
            {
                ID = 5,
                firstName = "Winny",
                lastName = "Adams"
            };
            Employee Employee6 = new Employee()
            {
                ID = 6,
                firstName = "Evan",
                lastName = "Smithers"
            };
            Employee Employee7 = new Employee()
            {
                ID = 7,
                firstName = "Hank",
                lastName = "Green"
            };
            Employee Employee8 = new Employee()
            {
                ID = 8,
                firstName = "Dwayne",
                lastName = "Samuels"
            };
            Employee Employee9 = new Employee()
            {
                ID = 9,
                firstName = "Roger",
                lastName = "Park"
            };
            Employee Employee10 = new Employee()
            {
                ID = 10,
                firstName = "Lisa",
                lastName = "Simpson"
            };

            List<Employee> Employees = new List<Employee>()
            { Employee1, Employee2, Employee3, Employee4, Employee5, Employee6, Employee7, Employee8, Employee9, Employee10 };

            List<Employee> Joe = new List<Employee>(); //ForEach Expression
            foreach (Employee x in Employees)
            {
                if (x.firstName != "Joe")
                {
                    Console.WriteLine(x.ID + " is not named Joe.");
                }

                else
                {
                    Console.WriteLine(x.ID + " is named Joe.");
                    Joe.Add(x);
                }
                Console.WriteLine("There are " + Joe.Count + " Joes.");
            }

            List<Employee> Joes = Employees.Where(x => x.firstName == "Joe").ToList(); //Lambda Expression
            Console.WriteLine("There are " + Joes.Count + " Joes.");

            List<Employee> newList = Employees.Where(x => x.ID > 5).ToList();
            Console.WriteLine(newList.Count + " has an ID greater than 5.");

        }
    }
}
