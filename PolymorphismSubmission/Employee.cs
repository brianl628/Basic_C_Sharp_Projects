using System;

public class Employee : Person, IQuittable
{
	public virtual void SayName()
	{
		base.SayName();
	}

	public void Quit() //quit function
    {
		Console.WriteLine("I Quit.");
    }
}
