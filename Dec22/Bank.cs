using System;
class Bank
{
    public int number1 { get; set; }
    public int number2 { get; set; }
    public int result { get; set; }

    public Bank(){
        number1 =0;
        number2 =0;
        result=0;
    }

    public int Add(int num1,int num2)
    {
        number1=num1;
        number2=num2;
        result=number1+number2;
        return result;
    }
    public void Sub()
    {   number1=32;
        number2=21;
        result=number1-number2;
        Console.WriteLine("Sub: "+result);
    }
    public int Multiply(int num1,int num2)
    {
        number1=num1;
        number2=num2;
        result=number1*number2;
        return result;
    }
    public void Divide()
    {   number1=54;
        number2=12;
        result=number1/number2;
        Console.WriteLine("Divide: "+result);
    }

}