using System;
using System.Collections.Generic;

namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] Fruits = { "apples", "bananas", "oranges", "watermelons", "starfruits" };
            //Console.WriteLine("Please add a fruit to the basket.");
            //string Fruit = Console.ReadLine();

            //for (int f = 0; f < Fruits.Length; f++) 
            //{
                //Console.WriteLine("You receieved " + Fruits[f]);
            //}



            // for (int f = 0; f >= 0; f++); infinite loop, change f value to something other than 0 to break infinite loop

            //List<string> foodList = new List<string>();
            //foodList.Add("Eggs");
            //foodList.Add("Milk");
            //foodList.Add("Pancakes");
            //foodList.Add("Tortilla");
            //foodList.Add("Sausage");
            //foodList.Add("Cheese");

            //Console.WriteLine("Guess what's on my grocery list!");
            //string food = Console.ReadLine();
            //foreach (string a in foodList)
            //{
                //if (foodList.Contains(food))
                //{
                    //Console.WriteLine(food + " is on on my grocery list and has an index of " + foodList.IndexOf(a));
                    //break;
                //}
                //else if (a != food)
                //{
                    //Console.WriteLine(food + " is not on my grocery list.");
                    //break;
                //}
            //}
            //Console.ReadLine();

            List<string> animalList = new List<string>();
            animalList.Add("dog");
            animalList.Add("cat");
            animalList.Add("cat");
            animalList.Add("horse");
            animalList.Add("horse");
            animalList.Add("duck");
            animalList.Add("monkey");

            Console.WriteLine("dog, cat, horse, duck, monkey");
            Console.WriteLine("Please pick an animal to check if there are any duplicates.");
            List<int> foundIndices = new List<int>();
            string searchDuplicate = Console.ReadLine();

            for (int a = 0; a < animalList.Count; a++)
            {
                if (animalList[a].Contains(searchDuplicate)) 
                {
                    foundIndices.Add(a);
                }
            }

            if (foundIndices.Count == 0)
            {
                Console.WriteLine("This animal is unique.");
            }

            else
            {
                Console.WriteLine("This animal is not unique. Duplicates are found here:");

               // for (int a = 0; a < animalList.Count; a++)
                //{
                    //if (animalList.LastIndexOf(animalList[a]) >= a && animalList.IndexOf(animalList[a]) == a)
                    //{
                        //Console.WriteLine(animalList[a] + " is unique");
                    //}
                    //else
                    //{
                        //Console.WriteLine(animalList[a] + " is a duplicate");
                    //}
                //}
                List<string> duplicateList = new List<string>();

                foreach (string animal in animalList)
                {
                    if (duplicateList.Contains(animal))
                    {
                        Console.WriteLine(animal + " has already occured.");
                    }
                    else
                    {
                        Console.WriteLine(animal + " has not occured.");
                        //add animal to the list
                    }
                }







            }

        }
    }
}
