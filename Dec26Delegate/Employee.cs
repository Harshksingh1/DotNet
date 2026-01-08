using System;
public class Employee
{
    protected int Eid,Eage;
    protected string Ename,Eaddress;
    protected float Salary;

    public virtual void GetEmployeeData()
    {
        Console.WriteLine("Enter Employee Details: ");
        Console.WriteLine("Enter the Eid: ");
        Eid=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name: ");
        Ename=Console.ReadLine();
        Console.WriteLine("Enter address: ");
        Eaddress=Console.ReadLine();
        Console.WriteLine("Enter Employee age: ");
        Eage=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Salary: ");
        Salary=float.Parse(Console.ReadLine());
    }
    public virtual void DisplayEmployeeData()
    {
        Console.WriteLine("Employee Details: ");
        Console.WriteLine("Employee Id: "+Eid);
        Console.WriteLine("Employee Name: "+Ename);
        Console.WriteLine("Employee Address: "+Eaddress);
        Console.WriteLine("Employee Age: "+Eage);
    }
    public virtual void CalculateSalary()
    {
        Console.WriteLine("Employee Salary: "+Salary);
    }
}