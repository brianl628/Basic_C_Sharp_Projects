using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string PackageWeight = Console.ReadLine();
            int Weight = Convert.ToInt32(PackageWeight);
            if (Weight > 50) //if else statement
            {
                Console.WriteLine("Package too big to be shipped via Package Express"); //ends program if weight is too big
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string PackageWidth = Console.ReadLine();
                int Width = Convert.ToInt32(PackageWidth);
                Console.WriteLine("Please enter the package height:");
                string PackageHeight = Console.ReadLine();
                int Height = Convert.ToInt32(PackageHeight);
                Console.WriteLine("Please enter the package length");
                string PackageLength = Console.ReadLine();
                int Length = Convert.ToInt32(PackageLength);
                int PackageTotal = (Width * Height * Length) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: "); //total shipping costs
                Console.WriteLine(PackageTotal); Console.WriteLine("Thank you!");
            }
        }
    }
}
