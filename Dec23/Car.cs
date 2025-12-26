using System;
using System.Security.Cryptography;
class Car
{
    public string make;
    public string model;
    public int year;

    public Car(string make,string model,int year)
    {
        this.make=make;
        this.model=model;
        this.year=year;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Car Deatails: ");
        Console.WriteLine("Make: "+make);
        Console.WriteLine("Model: "+model);
        Console.WriteLine("Year: "+year);
    }
    public void DisplayAge()
    {
        Console.WriteLine("Car Age: "+(2024-year));
    }
}