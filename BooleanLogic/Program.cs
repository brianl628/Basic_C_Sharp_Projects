using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int Age = Convert.ToInt32(yourAge);
            Console.WriteLine("Have you ever had a DUI?");
            string yourDUI = Console.ReadLine();
            bool noDUI = true;
            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(yourTickets);
            Console.WriteLine("Qualified?");
            bool overAge = (Age > 15 && noDUI && Tickets == 0);
            Console.ReadLine();
            Console.WriteLine(overAge);
        }
    }
}
