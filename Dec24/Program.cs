using System;
using System.Globalization;
using System.Text.RegularExpressions;
class Program
{
    public void Add(params int[] arr)
    {
        int sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=arr[i];
        }
        Console.WriteLine(sum);
    }
    public static void Main(string[] args)
    {
        //object initializer
        // Employee employee=new Employee
        // {
        //     EmployeeId=101,
        //     Name="Harsh",
        //     Salary=1234545
        // };
        // Console.WriteLine(employee.EmployeeId);
        // Console.WriteLine(employee.Name);
        // Console.WriteLine(employee.Salary);
        // Console.WriteLine(employee);
        // Console.WriteLine(employee.ToString());


        // Program program=new Program();
        // int[] arr={10,20,34,5,6,7,89};
        // program.Add(arr);

        // Calculator calculator=new Calculator();
        // calculator.Add(3,4);
        // calculator.Add("Harsh","Singh");
        // calculator.Add(5);


        // Vehicle v=new Vehicle(50.07,5.0,10.0);
        // v.Average();
        // v.Speed();
        // Car car=new Car(50.07,5.0,5.8);
        // car.Average();
        // car.Speed();


        //  Furniture furniture;//reference variable
        //  Bookshelve obj=new Bookshelve();
        //  obj.Accept();
        //  obj.Display();
        //  furniture=new Chair();
        //  Chair chair=new Chair();
        //  chair.Accept();
        //  chair.Display();



       UnitConverter u=new UnitConverter();
       Console.WriteLine("Enter Value: ");
       int Value=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter FromUnit: ");
       string FromUnit=Console.ReadLine();
       Console.WriteLine("Enter ToUnit: ");
       string ToUnit=Console.ReadLine();
       u.Convert(Value,FromUnit,ToUnit);
       u.Convert(Value,FromUnit);


    }
}