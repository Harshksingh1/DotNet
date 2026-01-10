// using System;
// using System.Diagnostics.Contracts;
// class InvalidpriceException :SystemException
// {
//     public string errorMessage;
//     public InvalidpriceException()
//     {
//         errorMessage="Error: Price must be greater than zero.";
//     }

// }
// class InvalidQuantityException : SystemException
// {
//     public string errorMessage;
//     public InvalidQuantityException()
//     {
//         errorMessage="Error: Quantity must be greater than zero.";
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             decimal price = decimal.Parse(Console.ReadLine());
//             if (price <= 0)
//             {
//                 throw new InvalidpriceException();
//             }
//             int Quantity = int.Parse(Console.ReadLine());
//             if (Quantity <= 0)
//             {
//                 throw new InvalidQuantityException();
//             }
//             if (price > 0 && Quantity > 0)
//             {
//                 Console.WriteLine("Total cost is "+price * Quantity);
//             }
//         }
//         catch(InvalidpriceException e)
//         {
//             Console.WriteLine(e.errorMessage);
//         }
//         catch(InvalidQuantityException e)
//         {
//             Console.WriteLine(e.errorMessage);
//         }
//         catch(FormatException e)
//         {
//            Console.WriteLine("Error: Please enter a valid number");

//         }
//     }
// }