using System;
class Employee
{
    private int EmpId=0;
    private string Name=string.Empty;
    private string Department=string.Empty;
    private float Salary=0.0f;
    private Boolean Status=true;

    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee Details: ");
        Console.WriteLine("Enter Employee Id: ");
        EmpId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee name: ");
        Name=Console.ReadLine();
        Console.WriteLine("Enter Employee Department");
        Department=Console.ReadLine();
        Console.WriteLine("Enter Employee Salary: ");
        Salary=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Employee status(True or False): ");
        Status=Convert.ToBoolean(Console.ReadLine());
    }
    public  int empid
    {
        get{return EmpId;}
        set{ EmpId=value;}
    }

     public  string name
    {
        get{return Name;}
        set{ Name=value;}
    }

     public string department
    {
        get{return Department;}
        set{ Department=value;}
    }

     public  float salary
    {
        get{return Salary;}
        set{ Salary=value;}
    }

     public  Boolean status
    {
        get{return Status;}
        set{ Status=value;}
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Deatils are: ");
        Console.WriteLine("Employee id: "+EmpId);
        Console.WriteLine("Employee Name: "+Name);
        Console.WriteLine("Employee Department: "+Department);
        Console.WriteLine("Employee Salary: "+Salary);
        Console.WriteLine("Employee status: "+status);
    }
}