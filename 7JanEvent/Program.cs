// using System;
// using System.IO.Pipelines;
// class Program //subscriber class
// {
    // private static int AddNumber(int param1,int param2){   //func delegate method
    //     return param1+param2;
    // }

    //  private static int result;      //acion delegate method
    //  private static void AddNumber(int param1,int param2){
    //     result=param1+param2;
    // }

    // private static bool IsApple(string modelName)           //predicate delegate method
    // {
    //     if(modelName=="Iphone X")
    //     return true;
    //     else
    //     return false;

    // }
    // public static void Main(string[] args)
    // {
        // AddTwoNumbers a=new AddTwoNumbers();
        // a.ev_OddNumber+=new AddTwoNumbers.dg_OddNumber(EventMessage);
        // a.Add();

    //    Func<int,int,int>Addition=AddNumber;       //func delegate
    //    int result=Addition(10,20);
    //    Console.WriteLine(result);

    //    Action<int,int>Addition=AddNumber;             //Action delegate
    //    Addition(10,20);
    //    Console.WriteLine(result);
        
    //     Predicate<string>checkIfApple=IsApple;          //predicate delegate
    //     bool result=IsApple("Iphone X");
    //     if(result)
    //     Console.WriteLine("It's and Iphone");

    // }
    // static void EventMessage()
    // {
    //     Console.WriteLine("**************Event Executed: This is odd numbers***************");
    // }
// }