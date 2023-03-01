using System;

namespace ClassSubmission
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Function Math = new Function(); //create new class
            Console.WriteLine("Please enter a number. It'll be divided by 2.");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int result; 
            Math.mathFunction(Num1, out result);
            Console.ReadLine();

        }
    }
}
