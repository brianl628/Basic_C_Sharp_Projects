using System;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int Num1 = Convert.ToInt32(Console.ReadLine()); //convert to integer
            Console.WriteLine("Please enter a second number.");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            myClass Math = new myClass();
            int result;
            Math.Addition(Num1, Num2, out result);




        }
    }
}
