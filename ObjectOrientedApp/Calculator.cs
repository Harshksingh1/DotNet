using System;
class Calculator
{
    private int number1;
    // public int Number1
    // {
    //     get
    //     {
    //         return number1;
    //     }
    //     set
    //     {
    //         number1=value;
    //     }
    // }
    public int Number1{ get; set; } //Autoimplement property
    public int Number2 { get; set; }
    public int result { get; set; }
    public Calculator()  //default constructor
    {
        Number1 =0;
        Number2=0;
        result=0;
    }
    public Calculator(int number1,int number2)
    {
        this.number1=number1;
        this.Number2=number2;
    }

    //method with parameter with return type
    public int Add(int number1,int number2)
    {
        Number1=number1;
        Number2=number2;
        result=Number1+Number2;
        return result;
    }
    //method without parameter with return typpe
    public int Subtract()
    {
        Number1=32;
        Number2=45;
        result=Number1-Number2;
        return result;
    }
    //method with parameter without return type
    public void Multiply(int number1,int number2)
    {
        Number1=number1;
        Number2=number2;
        result=Number1*Number2;
        Console.WriteLine("product of two number: "+result);
    }

    //method witout parameter without return type
    public void Divide()
    {
        result=Number1/Number2;
        Console.WriteLine("Division: "+result);
    }

    //inparameter passbyvalue
    public void swap(int num1,int num2)
    {
        int temp=0;
        
        Console.WriteLine($"Before swapping {num1} and {num2}");
        temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine($"After swapping {num1} and {num2}");
    }

    //inout parameter pass by reference  
    public void swap1(ref int num1,ref int num2)
    {
        int temp=0;
        
        Console.WriteLine($"Before swapping {num1} and {num2}");
        temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine($"After swapping {num1} and {num2}");
    }

    public void Addition(int n1,int n2, out int result,out int n3,out int n4)
    {
        n3=n1;
        n4=n2;
        result=n1+n2;
    }

}