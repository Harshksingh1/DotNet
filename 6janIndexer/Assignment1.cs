// using System;
// class Temperature
// {
//     public static void Main(string[] args)
//     {
//         try{
//         double temp=int.Parse(Console.ReadLine());
//         string convert=Console.ReadLine();
//             if (convert == "F")
//             {
//                 Console.WriteLine("Temperature in Celsius: "+((temp-32)*5/9));
//             }
//             else if (convert == "C")
//             {
//                 Console.WriteLine("Temperature in Fahrenheit: "+((temp*9/5)+32));
//             }
//             else
//             {
//                 Console.WriteLine("Invalid conversion type. please enter 'F' or 'C' .");
//             }
//         }
//         catch(FormatException e)
//         {
//             Console.WriteLine("Error: Invalid input provided");
//             Console.WriteLine("Exception message: "+e.Message);
//         }
//     }
// }