// using System;
// class Assignment
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter number of product: ");
//         int n=Convert.ToInt32(Console.ReadLine());
//         int[] arr=new int[n];
//         int sum=0;
//         for(int i = 0; i < n; i++)
//         {
//             Console.WriteLine($"Enter the product {i+1}: ");
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//             if(arr[i]<=0){
//             Console.WriteLine("price cannot be negative or zero");
//             return;
//             }
//             sum+=arr[i];
//         }
//        int avg=sum/n;
//         Array.Sort(arr);
//         for(int i = 0; i < n; i++)
//         {
//             if(arr[i]<avg)
//             arr[i]=0;
//         }
//         Array.Resize( ref arr,n+5);
//         for(int i = n; i < arr.Length; i++)
//         {
//             arr[i]=avg;
//         }
//         for(int i = 0; i < arr.Length; i++)
//         {
//             Console.WriteLine(i+" "+arr[i]);
//         }
//     }
// }