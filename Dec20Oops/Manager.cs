using System;
using System.Security.Cryptography;
class Manager
{
    private int EmpId=0;
    private string Name=string.Empty;
    private float Salary=0.0f;

    float pf,hra,da,grossSalary,netSalary;

   public void calculateSalary()
    {
        pf = salary * 0.12f;
        hra = salary * 0.20f;
        da = salary * 0.15f;

        grossSalary = salary + pf + hra + da;
        netSalary = grossSalary - pf;
    }
    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee Details: ");
        Console.WriteLine("Enter Employee Id: ");
        EmpId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee name: ");
        Name=Console.ReadLine();
        Console.WriteLine("Enter Employee Salary: ");
        Salary=Convert.ToSingle(Console.ReadLine());
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

     public  float salary
    {
        get{return Salary;}
        set{ Salary=value;}
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Deatils are: ");
        Console.WriteLine("Employee id: "+EmpId);
        Console.WriteLine("Employee Name: "+Name);
        Console.WriteLine("Employee Salary: "+Salary);
        Console.WriteLine("Employee gross salary: "+grossSalary);
        Console.WriteLine("Employee net salary: "+netSalary);

    }
}




/*program to read eno,ename,basic salary and calculate  
pf,hra,da,net salary and gross salary and print eno,ename,basic 
salary,
gross salary and net salary*/

// pf= 12% of basic salary.
// hra=20% of basic salary.
// da= 15% of basic salary.
// gross salary=pf+hra+da+basic salary;
// net salary=gross salary - pf;