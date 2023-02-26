using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many dogs do I have?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuess = number == 1;

            do    //do statement
            {
                switch (number) //different cases to send back to beginning of loop
                {
                    case 2:
                        Console.WriteLine("You guessed 2. Try again.");
                        Console.WriteLine("Guess how many dogs I have.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess how many dogs I have.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You guessed 1. This is correct!");
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess how many dogs I have.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuess); //while statement
            Console.Read();
        }
    }
}
