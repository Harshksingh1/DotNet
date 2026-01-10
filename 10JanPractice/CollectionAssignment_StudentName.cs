// using System;
// using System.Collections;

// class Program
// {

//   private static bool IsValidName(string name)
//   {
//     return !string.IsNullOrEmpty(name);
//   }

//   private static bool IsNameInCollection(ArrayList studentNames, string name)
//   {
//     foreach (string item in studentNames)
//         {
//             if (item.Equals(name, StringComparison.OrdinalIgnoreCase))
//             {
//                 return true; 
//             }
//         }
//         return false;
//   }
//   private static void DisplayStudentNames(ArrayList studentNames)
//   {
//     foreach (var item in studentNames)
//     {
//       Console.WriteLine(item);
//     }
   
//   }
//   public static void Main()
//   {
//     Program p=new Program();
//     ArrayList list=new ArrayList();
//     Console.WriteLine("Enter the student name");

//     while (true)
//     {
//       string str=Console.ReadLine();
//       if (str == "stop")
//       {
//         break;
//       }

//       if (Program.IsValidName(str))
//       {
//         if (!Program.IsNameInCollection(list,str))
//         {
//            list.Add(str);

//            Console.WriteLine(str+" is added to the list");

//         }
//         else
//         {
//           Console.WriteLine(str+" is already exist");
//         }
        
//       }
//       else{
       
      
//     }
    
  
//   }
//     Program.DisplayStudentNames(list);
  
// }
// }