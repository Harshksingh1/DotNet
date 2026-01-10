// using System;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             int number = int.Parse(Console.ReadLine());
//             decimal price = decimal.Parse(Console.ReadLine());
//             if (number <= 0)
//             {
//                 throw new ArgumentException("Error: Number of tickets must be greater than 0.");
//             }
//             if (price <= 0)
//             {
//                 throw new ArgumentException("Error: price per ticket must be greater than 0.");
//             }
        
//                 Console.WriteLine("Total ticket cost "+number * price);
            
//         }
//         catch(ArgumentException e1)
//         {
//             Console.WriteLine(e1.Message);
//         }
//         catch(FormatException e)
//         {
//            Console.WriteLine("Error: Please enter a valid number");

//         }
//     }
// }