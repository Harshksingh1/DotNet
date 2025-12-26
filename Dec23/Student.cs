using System;
class Student
{
    public string name;
    public int age;
    public char grade;

    public Student()   //default
    {
        name="Jahn Doe";
        age=21;
        grade='A';
    }
    public Student(string name,int age,char grade)  //parameterised
    {
        this.name=name;
        this.age=age;
        this.grade=grade;
    }
    public void DefaultValue()
    {
        Console.WriteLine("Default Student: ");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Grade: "+grade);
    }
    public void NewValue()
    {
        Console.WriteLine("New Student: ");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Grade: "+grade);
    }
}