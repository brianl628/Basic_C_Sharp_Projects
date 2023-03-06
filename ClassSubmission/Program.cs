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

            Function Math2 = new Function();
            Console.WriteLine("Please enter a decimal number. It'll be divided by 2");
            decimal Num2 = Convert.ToDecimal(Console.ReadLine());
            decimal result2;
            Math2.mathFunction(Num2, out result2);
            Console.ReadLine();
            Console.WriteLine("Your new numbers are " + result + " and " + result2);
        }
    }
}
