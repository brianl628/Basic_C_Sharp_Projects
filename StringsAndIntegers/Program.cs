using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  //list
            try
            {
                Console.WriteLine("Please enter an integer to divide:");
                int input = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numberList)
                {
                    Console.WriteLine(Convert.ToString(num / input)); //divides by integer input
                }
            }
            catch (FormatException) //catches things not applicable to the division
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException) //catches if someone enters 0
            {
                Console.WriteLine("Please enter a number aside from 0 in the denominator.");
            }
            finally
            {
                Console.WriteLine("Integer division attempted");
                Console.ReadLine();
            }
        }
    }
}
