using System;


public class Function
{
    public void mathFunction(int input, out int output) //void method
    {
        output = input / 2; //divide by 2
        Console.WriteLine("Your result is " + output); //output result
    }
    public void mathFunction(decimal input, out decimal output)
    {
        output = input / 2;
        Console.WriteLine("Your result is " + output); //overload method
    }
}
