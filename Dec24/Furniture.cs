using System;
public abstract class Furniture
{
    protected int num;
    protected string color;
    protected int width;
    protected int height;
    public abstract void Accept();
    public abstract void Display();
    public void MyMethod()
    {
        Console.WriteLine("MyMethod");
    }
}

class Bookshelve : Furniture
{
    public override void Accept()
    {
        Console.WriteLine("Enter no. of shelves: ");
        num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter color: ");
        color=Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Width: ");
        width=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height: ");
        height=Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        Console.WriteLine("Num: "+num);
        Console.WriteLine("Color: "+color);
        Console.WriteLine("Width: "+width);
        Console.WriteLine("Height: "+height);

    }
}
class Chair : Furniture
{
    public override void Accept()
    {
        Console.WriteLine("Enter no. of Chairs: ");
        num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter color: ");
        color=Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Width: ");
        width=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height: ");
        height=Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        Console.WriteLine("Num: "+num);
        Console.WriteLine("Color: "+color);
        Console.WriteLine("Width: "+width);
        Console.WriteLine("Height: "+height);

    }
}