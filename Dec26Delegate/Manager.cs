using System;
class Manager:Employee
{
    double Bonus,CA;

    public override void GetEmployeeData()
    {
        Console.WriteLine("Enter Manager Details: ");
        Console.WriteLine("Enter the Mid: ");
        Eid=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name: ");
        Ename=Console.ReadLine();
        Console.WriteLine("Enter Bonus: ");
        Bonus=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the CA: ");
        CA=Convert.ToDouble(Console.ReadLine());
    }
    public override void DisplayEmployeeData()
    {
        Console.WriteLine("Manager Details: ");
        Console.WriteLine("Manager Id: "+Eid);
        Console.WriteLine("Manager Name: "+Ename);
        Console.WriteLine("Manager Bonus: "+Bonus);
        Console.WriteLine("Manager CA: "+CA);
    }
}