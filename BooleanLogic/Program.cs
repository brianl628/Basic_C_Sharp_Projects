using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?"); //writes questions for user input
            string yourAge = Console.ReadLine();
            int Age = Convert.ToInt32(yourAge);
            Console.WriteLine("Have you ever had a DUI?");
            string yourDUI = Console.ReadLine();
            bool noDUI = false;
            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(yourTickets);
            Console.WriteLine("Qualified?");
            bool qualified = (Age > 15 && noDUI && Tickets == 0); //boolean statement to determine qualified
            Console.ReadLine();
            Console.WriteLine(qualified);
        }
    }
}
