using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //Prints whatever is between the quotations
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?"); //Begins the questions
            string yourName = Console.ReadLine(); //Define the string
            Console.ReadLine(); //Console reads the line before moving to the next step
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("What page number?");
            string yourPageNumber = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false.'");
            string yourHelp = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        }
    }
}
//End Program