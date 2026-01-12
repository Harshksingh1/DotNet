// using System;
// using System.Security.Cryptography.X509Certificates;
// class program
// {
//     public static void Mymethod(dynamic dy)
//     {
//         Console.WriteLine("Details of employee using dynamic keyword:");
//         Console.WriteLine("Name of employee is: "+dy.name);
//         Console.WriteLine("Id of employee is: "+dy.id);

//     }
//     public delegate void Print(int val,string str);
//     public delegate void Print1(int val);
//     public static void PrintHelperMethod(Print1 printDel,int val)
//     {
//         val+=10;
//         printDel(val);
//     }

//     public static void Main(string[] args)
//     {
//       PrintHelperMethod(delegate (int val){
//       Console.WriteLine("Anonymous methos {0}",val);
//     },100);

//     Print print=delegate (int val, string str)
//     {
//       Console.WriteLine("hello world "+ val+" "+str);
//     };
//     print(100,"Welcome");

//     var ManagerInfo=new
//     {
//       id=1001,
//       name="Harsh"
//     };

//     Console.WriteLine("Manager id is "+ManagerInfo.id);
//     Console.WriteLine("Manger name is "+ManagerInfo.name);

//     Mymethod(ManagerInfo);
//     }
// }