using System;
class Employee
{
    public int EmployeeId{ get; set; }
    public string Name { get; set; }
    public float Salary { get; set; }

    public Employee()
    {
        EmployeeId=0;
        Name=string.Empty;
        Salary=0.0f;
    }
     public Employee(int EmployeeId,string Name,float Salary)
    {
        this.EmployeeId=EmployeeId;
        this.Name=Name;
        this.Salary=Salary;
    }

    //overiding the two string method
    public override string ToString()
    {
        return "Employee Details are: "+ EmployeeId+" "+ Name+" "+Salary;
    }
}