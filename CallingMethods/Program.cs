using Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation mathObject = new Operation(); 
            int Num3 = 10;
            int Num4 = 11;
            int Num5 = 12;
            Console.WriteLine("Please enter a number.");
            int Num = Convert.ToInt32(Console.ReadLine()); //convert to integer

            Num3 = mathObject.Addition(Num); //calling methods of operations
            Num4 = mathObject.Division(Num);
            Num5 = mathObject.Multiplication(Num);

            Console.WriteLine("Adding 10 to " + Num + " equals " + Num3); //produces output of each math operator
            Console.WriteLine("Dividing 10 to " + Num + " equals " + Num4);
            Console.WriteLine("Multiplying 10 to " + Num + " equals " + Num5);

        }
    }
}


