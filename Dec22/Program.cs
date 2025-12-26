using System;
using System.ComponentModel;
class Program
{
    public static void Main(string[] args)
    {
        // Bank bank=new Bank();
        // Console.WriteLine("Add: "+bank.Add(2,3));
        // bank.Sub();
        // Console.WriteLine("Multiply: "+bank.Multiply(4,7));
        // bank.Divide();


        StaticinstanceDemo demo=new StaticinstanceDemo();
        // demo.var=30;
        // demo.var1=32; //error cannot access static variable or method through instance
        // StaticinstanceDemo.var1=30;

        demo.count();
        demo.count();
        demo.count();
        Console.WriteLine(demo.Display());


        StaticinstanceDemo demo1=new StaticinstanceDemo();
        demo1.count();
        demo1.count();
        demo1.count();
        Console.WriteLine(demo1.Display());

    }
}