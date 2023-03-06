using System;

public class Employee : Person
{
	public int ID { get; set; }
	public static bool operator ==(Employee Employee1, Employee Employee2)
    {
		if (Employee1.ID == Employee2.ID) //check if IDs are equal
        {
            return Employee1.ID == Employee2.ID;
        }
        else
        {
            return false; //if different, produce false result
        }
    }
    public static bool operator !=(Employee Employee1, Employee Employee2)
    {
        return Employee2 != Employee1; //overload
    }

    public override bool Equals(object obj)
    {
        Employee employee = obj as Employee;
        if (employee == null)
        {
            return false;
        }
        return this.ID.Equals(employee.ID);
    }
    public override int GetHashCode()
    {
        return ID.GetHashCode();
    }
}
	

