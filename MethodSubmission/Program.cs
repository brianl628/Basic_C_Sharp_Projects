using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Function MathClass = new Function();
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number. You do not need to enter a second number if you don't want to.");
            string num2 = (Console.ReadLine());

            if (num2.Equals(string.Empty))
            {
                Console.WriteLine("Your total comes out to " + MathClass.Multiply(num1));
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Console.WriteLine("Your total comes out to " + MathClass.Multiply(num1, num3));
            }

        }
    }
}
