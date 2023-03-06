using System;

public class Employee : Person
{
	public override void SayName() //override method
	{

	Console.WriteLine("Name: " + FirstName + " " + LastName); //outputs full name
		
	}
}
