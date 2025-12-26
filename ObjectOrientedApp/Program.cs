using System;
class Program
{
    // static int fact(int n)
    //     {
    //         if(n==0 || n==1)
    //         return 1;

    //     return n*fact(n-1);
    //     }
    public static void Main(string[] args)
    {
        // Employee employee=new Employee();  //creating object
        // employee.AcceptDetails();  //binding the employee object with AcceptDetails function
        // employee.DisplayDetails();
        // Console.ReadKey();


        // Employee employee1=new Employee();
        // employee1.empid=10304;
        // employee1.name="HARSH";
        // employee1.department="IT";
        // employee1.salary=234567;
        // employee1.status=true;

        // employee1.DisplayDetails();


        //  Manager manager=new Manager();
        //  manager.AcceptDetails();
        //  manager.calculateSalary();
        //  manager.DisplayDetails();


        // Student student=new Student();
        //  student.AcceptDetails();
        //  student.TotalandAverage();
        //  student.DisplayDetails();
        //  student.gradeDetails();

        //==========leap year============

        // Console.WriteLine("Enter the year: ");
        // int year=Convert.ToInt32(Console.ReadLine());
        // if(year%400==0)
        // Console.WriteLine("is a Leap year");
        // else if(year%100!=0 && year%4==0)
        // Console.Write("is Leap year");
        // else
        // Console.WriteLine("not a leap year");


        //=========Celsius to Fahrenheit ========

        // Console.WriteLine("Enter the number: ");
        // float c=Convert.ToSingle(Console.ReadLine());
        // Console.WriteLine("temperature in fahrenheit: "+((c * 9 / 5) + 32));

        //==========grade=======-

        // int marks=Convert.ToInt32(Console.ReadLine());
        // if(marks>=90) Console.WriteLine("Student grade is GRADE A");
        // else if(marks>=80 && marks<90) Console.WriteLine("Student grade is GRADE B");
        // else if(marks>=70 && marks<80) Console.WriteLine("Student grade is GRADE c");
        // else if(marks>=60 && marks<70) Console.WriteLine("Student grade is GRADE D");
        // else Console.WriteLine("Student grade is GRADE E");

        //========factorial========
        
        // while (true)
        // {
        //     char c=Convert.ToChar(Console.ReadLine());
        //     if (c == 'q')
        //     {
        //         Console.WriteLine("exit");
        //         break;
        //     }
        //     else{
        //     int num=c-'0';
        //     Console.WriteLine($"The factorial of {num} is: "+fact(num));
        //     }
        // }

        //=========sum of n natural number==========
        // int n=Convert.ToInt32(Console.ReadLine());
        // int sum=0;
        // for(int i = 1; i <= n; i++)
        // {
        //     sum+=i;
        // }
        // Console.WriteLine($"Sum of first {n} natural number is: "+sum);

        
        //========calculator.cs========
        
        Calculator calculator=new Calculator();
        int number1=10;
        int number2=45;
        int sum=calculator.Add(number1,number2);
        Console.WriteLine("Sum: "+sum);

        Console.WriteLine("Sum: "+calculator.Add(34,56));
      
        Console.WriteLine("sub: "+calculator.Subtract());

        Calculator calculator1=new Calculator(30,2);
        calculator1.Multiply(30,20);
        calculator1.Divide();


        Calculator calculator2=new Calculator();
        calculator2.swap(30,20);

        //call by reference
        int n1=30;
        int n2=50;
        calculator2.swap1(ref n1,ref n2);


        Calculator calculator3=new Calculator();
        int num1=30;
        int num2=50;
        int result=0;
        int num3=0;
        int num4=0;
        calculator3.Addition(num1,num2,out result,out num3,out num4);
        Console.WriteLine($"First number is {num3} second number is {num4} and Additiion is {result}");

    }
}