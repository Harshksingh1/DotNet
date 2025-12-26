using System;
class Calculator
{
    //methhod overloading
    public void Add(int num1,int num2)
    {
        Console.WriteLine("Sum: "+(num1+num2));
    }
    public void Add(string name1,string name2)
    {
        Console.WriteLine(name1+name2);
    }
    public void Add(int n)
    {
        int num1=5;
        int num2=n;
        int result=num1+num2;
        Console.WriteLine(result);
    }
    
}