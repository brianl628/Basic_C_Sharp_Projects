using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int testScore = 50;
            ScoreImprovement newScore = new ScoreImprovement(); 
            Console.WriteLine("Enter how many hours you've studied.");
            int Input = Convert.ToInt32(Console.ReadLine()); //convert to int
            testScore = newScore.ScoreIncrease(Input);
            Console.WriteLine("You have studied for " + Input + " hours. Your score has now increased to " + testScore); //display test score after x amount of hours

            Console.WriteLine("Enter how many hours you've studied to the nearest tenth.");
            double Input2 = Convert.ToDouble(Console.ReadLine()); //convert to decimal
            testScore = newScore.ScoreIncrease(Input2);
            Console.WriteLine("You have studied for " + Input2 + " hours. Your score has now increased to " + testScore);
            int testScore2 = 50;

            Console.WriteLine("Enter how many hours you've studied as words.");
            int Input3 = Convert.ToInt32(Console.ReadLine()); //convert string to int
            testScore2 = newScore.ScoreIncrease(Input3);
            Console.WriteLine("You have studied for " + Input3 + " hours. Your score has now increased to " + testScore);
        }
    }
}
