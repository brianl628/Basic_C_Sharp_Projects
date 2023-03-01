using System;

namespace PolymorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable test = new Employee(); 
            test.Quit(); //calls for quit function

        }
    }
}
