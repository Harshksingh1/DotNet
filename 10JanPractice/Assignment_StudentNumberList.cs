// using System;
// using System.Collections;

// class Program
// {
//     private static void AddNumber(ArrayList list)
//     {
//         string input = Console.ReadLine();

//         if (int.TryParse(input, out int num))
//         {
//             list.Add(num);
//             Console.WriteLine(num + " added to the number list.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void RemoveNumber(ArrayList list)
//     {
//         string input = Console.ReadLine();

//         if (int.TryParse(input, out int num))
//         {
//             if (list.Contains(num))
//             {
//                 list.Remove(num);
//                 Console.WriteLine(num + " removed from the number list.");
//             }
//             else
//             {
//                 Console.WriteLine(num + " not found in the number list.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void DisplayNumbers(ArrayList list)
//     {
//         Console.WriteLine("Current numbers in the list:");
//         foreach (var item in list)
//         {
//             Console.WriteLine(item);
//         }
//     }

//     public static void Main(string[] args)
//     {
//         ArrayList numbers = new ArrayList();

//         while (true)
//         {
//             string command = Console.ReadLine();
//             switch (command)
//             {
//                 case "add":
//                     AddNumber(numbers);
//                     break;
//                 case "remove":
//                     RemoveNumber(numbers);
//                     break;
//                 case "display":
//                     DisplayNumbers(numbers);
//                     break;
//                 case "exit":
//                     return;
//                 default:
//                     Console.WriteLine("Invalid command.");
//                     break;
//             }
//         }
//     }
// }