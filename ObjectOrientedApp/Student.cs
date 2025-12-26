using System;
using System.Security.Cryptography;
class Student
{
    private int StuId=0;
    private string Name=string.Empty;
    float Msub1,Msub2,Msub3,Msub4,Msub5,Msub6=0.0f;
    float total,avg=0.0f;

    
   public void TotalandAverage()
    {
        total=Msub1+Msub2+Msub3+Msub4+Msub5+Msub6;
        avg=total/6;
    }
    public void gradeDetails()
    {
         if(avg>=90) Console.WriteLine("Student grade is GRADE A");
        else if(avg>=80 && avg<90) Console.WriteLine("Student grade is GRADE B");
        else if(avg>=70 && avg<80) Console.WriteLine("Student grade is GRADE c");
        else if(avg>=60 && avg<70) Console.WriteLine("Student grade is GRADE D");
        else Console.WriteLine("Student grade is GRADE E");
    }
   
    public void AcceptDetails()
    {
        Console.WriteLine("Enter Student Details: ");
        Console.WriteLine("Enter Student Id: ");
        StuId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student name: ");
        Name=Console.ReadLine();
        Console.WriteLine("Enter Employee Marks(6 Subjects): ");
        Msub1=Convert.ToSingle(Console.ReadLine());
        Msub2=Convert.ToSingle(Console.ReadLine());
        Msub3=Convert.ToSingle(Console.ReadLine());
        Msub4=Convert.ToSingle(Console.ReadLine());
        Msub5=Convert.ToSingle(Console.ReadLine());
        Msub6=Convert.ToSingle(Console.ReadLine());
    }
    public  int stuid
    {
        get{return StuId;}
        set{ StuId=value;}
    }

     public  string name
    {
        get{return Name;}
        set{ Name=value;}
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine("Student Deatils are: ");
        Console.WriteLine("Student id: "+StuId);
        Console.WriteLine("Student Name: "+Name);
        Console.WriteLine("total: "+total);
        Console.WriteLine("Average: "+avg);
    }
}



/*
12) program to read student num,name,mark of six subject in property and 
calculate total and average and print result and division 
program that reads a student’s exam score from the user and determines their grade based on the following grading scale:
•	Score ≥ 90 : Grade A
•	80 ≥ Score < 90 : Grade B
•	70 ≥ Score < 80 : Grade C
•	60 ≥ Score < 70 : Grade D
•	Score < 60 : Grade F
*/