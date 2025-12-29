using System;
class Employee:IComparable<Employee>
{
    public int ID { get; set; }
    public string Name { get; set; }

    public int CompareTo(Employee other)
    {
        return this.ID.CompareTo(other.ID);//in Asc order
    }
    public override string ToString()
    {
        return "Your EmployeeID: "+ID+" and Name is: "+Name;
    }
}