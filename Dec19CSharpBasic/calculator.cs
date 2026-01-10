using System;
using System.ComponentModel;
namespace HelloWorldApp{
class calculator
{
    int a;
    int b;
    
    int result;


    public void add()
    {
        Console.WriteLine("Enter a: ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        b=int.Parse(Console.ReadLine());
        result=a+b;
        Console.WriteLine($"Addition: {result}");
    }
    public void sub()
        {
        Console.WriteLine("Enter a: ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        b=int.Parse(Console.ReadLine());
        result=a-b;
        Console.WriteLine($"Subtraction: {result}");
        }

         public void mul()
        {
        Console.WriteLine("Enter a: ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        b=int.Parse(Console.ReadLine());
        result=a*b;
        Console.WriteLine($"Multiplication: {result}");
        }
         public void div()
        {
        Console.WriteLine("Enter a: ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        b=int.Parse(Console.ReadLine());
        result=a/b;
        Console.WriteLine($"division: {result}");
        }
}
}


