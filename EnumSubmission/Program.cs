using System;

namespace EnumSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try + catch block
            {
                Console.Write("Please enter a day of the week.");
                string input = Console.ReadLine();
                DaysofWeek yourInput = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), input, true); //parse enum
            }
            catch //catch if input is anything other than a day
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
        public enum DaysofWeek 
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
