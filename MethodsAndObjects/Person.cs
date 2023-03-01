using System;

public class Person
{
	public void SayName() 
	{
		Console.WriteLine("Name: " + FirstName + " " + LastName); //writes employee name 
		Console.ReadLine();
	}
	public string FirstName { get; set; }
	public string LastName { get; set; }
	

}
	
	

