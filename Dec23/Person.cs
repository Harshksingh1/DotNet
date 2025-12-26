using System;
class Person
{
      private string name;
      private string address;
      private int age;
     
     public string Name
    {
        get{ return name;}
        set{name=value;}
    }
    public string Address
    {
        get{return address;}
        set{address=value;}
    }
    public int Age
    {
        get{return age;}
        set{age=value;}
    }
      public void DisplayDetails()
    {
        Console.WriteLine("Person Details: ");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Address: "+address);
        Console.WriteLine("Age: "+age);
    }

}