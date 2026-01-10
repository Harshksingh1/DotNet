using System;
 
namespace HelloWorldApp
{
class Employee
{
    int id;
    string name;
    string department;
    float salary;
    char Gender;

    public void AcceptDetails()
    {
          Console.WriteLine("Enter Employee Details: ");

        Console.WriteLine("Enter Employee Id: ");
        id=Convert.ToInt32(Console.ReadLine());
        // id=int.Parse(Console.ReadLine);

        Console.WriteLine("Enter name: ");
        name=Console.ReadLine();

        Console.WriteLine("Enter department: ");
        department=Console.ReadLine();

        Console.WriteLine("Enter salary: ");
        salary=Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter gender: ");
        id=Convert.ToChar(Console.ReadLine());
    }
    public void DisplayDetails()
    {
      Console.WriteLine("Employee details are: ");
       Console.WriteLine($"Employee id is: {id}");
       Console.WriteLine($"Employee name is: {name}");
       Console.WriteLine($"Employee dept is: {department}");
       Console.WriteLine($"Employee salary is: {salary}");
       Console.WriteLine($"Employee gender is: {Gender}");



    }
}

}