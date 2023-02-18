using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymouse Income Comoparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string HourlyRate = Console.ReadLine();
            int Rate = Convert.ToInt32(HourlyRate); //convert to integer from string
            Console.WriteLine("How many hours worked per week?");
            string WeeklyHours = Console.ReadLine();
            int Hours = Convert.ToInt32(WeeklyHours);
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string HourlyRate2 = Console.ReadLine();
            int Rate2 = Convert.ToInt32(HourlyRate2);
            Console.WriteLine("How many hours worked per week?");
            string WeeklyHours2 = Console.ReadLine();
            int Hours2 = Convert.ToInt32(WeeklyHours2);
            Console.WriteLine("Annual Salary of Person 1");
            int product = Rate * Hours; //multiplies values for annual salary
            Console.WriteLine(product);
            Console.WriteLine("Annual Salary of Person 2");
            int product2 = Rate2 * Hours2;
            Console.WriteLine(product2); 
            int Person1 = product;
            int Person2 = product2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = product > product2; //boolean statement
            Console.WriteLine(moreMoney);
            Console.ReadLine();

        }
    }
}
