using System;

namespace DateAndTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now; //list current date/time
            Console.WriteLine("The current date/time is " + currentTime);
            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine()); //convert to integer
            Console.WriteLine("The time in X hours is " + currentTime.AddHours(userInput)); //add x hours to current time
            Console.ReadLine();
        }
    }
}
