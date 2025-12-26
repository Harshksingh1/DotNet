using System;
namespace PartialDemo
{
    public partial class PartialEmployee{
    
    
    public void DisplayFullName()
        {
            Console.WriteLine(FirstName+LastName);
        } 
    public void DisplayEmployeeDetails()
    {
      Console.WriteLine("Employee Details: ");
      Console.WriteLine("First Name: "+firstName);
      Console.WriteLine("last Name: "+lastName);
      Console.WriteLine("Gender is"+gender);
      Console.WriteLine("Salary is "+salary);
    }

    }
}