using System;

public class Employee
{
	public string name;
	public string status;
	public Employee(string name) : this(name, "Employed") { } //chain constructors
	public Employee (string name, string status) 
    {
		this.name = name;
		this.status = status;
    }
}
