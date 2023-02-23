using System;

namespace AppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "dog", "cat", "frog", "horse" };   //create string
            Console.WriteLine("Pick a number between 0 and 3 for an animal.");
            int Index = Convert.ToInt32(Console.ReadLine());    //makes an index
            if (Index >= 0 && Index <= 3)
            {
                Console.WriteLine("You received a " + animals[Index]);  //retrieves info from index depending on user input
            }
            else
            {
                Console.WriteLine("You didn't pick a number between 0 and 3. Please pick a number between 0 and 3.");
            }

            int[] intArray = { 0, 1, 3, 27, 81 };   //integer array
            Console.WriteLine("Please pick a number between 0 and 4");
            int Index2 = Convert.ToInt32(Console.ReadLine());
            if (Index2 >= 0 && Index2 <= 4)
            {
                Console.WriteLine("You got a number of " + intArray[Index2]);
            }
            else
            {
                Console.WriteLine("You didn't pick a number between 0 and 4. Please pick a number between 0 and 4.");
            }

            List<string> strList = new List<string>();//create new list
            strList.Add("Pizza");
            strList.Add("Burger");
            strList.Add("Burrito");
            strList.Add("Pasta");

            Console.WriteLine("Please pick a number between 0 and 3.");
            int Foods = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose " + strList[Foods]);
            Console.ReadLine();



        }
    }
}
