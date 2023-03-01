using System;

public abstract class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public virtual void SayName() //void 
    {
		Console.WriteLine("Name: " + FirstName + " " + LastName); //outputs full name
    }
}
