// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
        // Employee employee=new Employee();
        // employee[0]="Harsh";
        // employee[1]="Vivek";
        // employee[2]="Ravi";
        // employee[3]="Shubham";
        // employee[4]="Abhi";
        // for(int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(employee[i]);
        // }
        // Console.WriteLine(employee["Harsh"]);

        //=============================Exception Handling==================================
        // int num1=0;
        // int num2=0;
        // int result=0;
        // Console.WriteLine("Enter num1: ");
        // num1=int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter num2: ");
        // num2=int.Parse(Console.ReadLine());
        // try{
        // result=num1/num2;
        // }
        // catch
        // {
        //     Console.WriteLine("cannot divide by zero");
        // }
        // finally{
        // Console.WriteLine("division of num1 and num2 is: "+result);
        // }


        // int num1=0;
        // int num2=0;
        // int result=0;

        // int[] arr=new int[6]{1,2,3,4,5,6};

        // try{
        // Console.WriteLine("Enter num1: ");
        // num1=int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter num2: ");
        // num2=int.Parse(Console.ReadLine());
        // result=num1/num2;
        //     try
        //     {
        //         for(int i = 0; i < 9; i++)
        //         {
        //             Console.WriteLine(arr[i]);
        //         }
        //     }
        //     catch(IndexOutOfRangeException e)
        //     {
        //         Console.WriteLine(e.Message);
        //     }
        //     finally
        //     {
        //         Console.WriteLine("code executed");
        //     }
        // }
        // catch(DivideByZeroException e)
        // {
        //     Console.WriteLine(e.Message.ToString());
        // }
        // catch(FormatException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // catch(Exception e)   //can catch any type of exception like divide by zero ,format exception and then show accordingly
        // {
        //     Console.WriteLine(e.Message);
        // }
        // finally{
        // Console.WriteLine("division of num1 and num2 is: "+result);
        // }


        //==========================throw============================ 
//         try
//         {
//                 throw new MyException("HARSH");

//         }
//         catch (Exception e)
//         {
//             Console.WriteLine("Error: " + e.Message);
//         }
    

//     }
// }



//try cannot be alone it should be followed by catch and finally or both
//we can write try,catch,finally inside a try block
//finally will surely execute
