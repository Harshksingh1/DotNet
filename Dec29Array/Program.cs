using System;

class Program
{
//     public int ReturnArray(int[] arr)
//         {
//             int sum=0;
//             for(int i = 0; i < arr.Length; i++)
//         {
//             sum+=arr[i];
//         }
//         return sum;
//         }
//      public int[] PassArray(int n)
//     {
//         int[] arr=new int[n];
//         for(int i = 0; i < n; i++)
//         {
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         return arr;
//     } 
    public static void Main(string[] args)
    {
        // int[] arr=new int[6];
        // arr[0]=10;
        // arr[1]=20;
        // arr[2]=65;
        // arr[3]=45;
        // arr[4]=76;
        // arr[5]=87;
        // // Console.WriteLine(arr.Length);
        // Console.WriteLine(arr.GetLength(0));
        // for(int i = 0; i < arr.Length; i++)
        // {
        //     Console.Write(arr[i]+" ");
        // }
        // Console.WriteLine();
        // foreach(int i in arr)
        // {
        //     Console.Write(i+" ");
        // }
    //   Program p=new Program();
    //   int[] arr=p.PassArray(6);
    //   Console.WriteLine(p.ReturnArray(arr));
        
      //2D array
    //   int[,] arr=new int[3,3];
    //   arr[0,0]=10;
    //   arr[0,1]=10;
    //   arr[0,2]=10;
    //   arr[1,0]=10;
    //   arr[1,1]=10;
    //   arr[1,2]=10;
    //   arr[2,0]=10;
    //   arr[2,1]=10;
    //   arr[2,2]=10;
    //   for(int i = 0; i < 3; i++)
    //     {
    //         for(int j = 0; j < 3; j++)
    //         {
    //             Console.Write(arr[i,j]+" ");
    //         }
    //         Console.WriteLine();
    //     }

    //reverse an array
    // int[] arr={2,3,4,5,6,7};
    // for(int i = arr.Length-1;i>=0;i--)
    //     {
    //         Console.Write(arr[i]+" ");
    //     }

    //copy array into other array
    // int[] arr={2,3,4,5,6,7};
    // int[] copy=new int[arr.Length];
    // for(int i = 0;i<arr.Length;i++)
    //     {
    //         copy[i]=arr[i];
    //     }
    // for(int i = 0;i<arr.Length;i++)
    //     {
    //         Console.Write(copy[i]+" ");
    //     }

    // //unique element
    // int[] arr={1,2,3,1,4,3,2,7,2};
    // List<int> result = new List<int>();

    // for(int i = 0; i < arr.Length; i++)
    //     {
    //         bool istrue=true;
    //         for(int j = 0; j < arr.Length; j++)
    //         {
    //             if(arr[i]==arr[j]&& i!=j){
    //             istrue=false;    
    //             break;
    //             }
    //         }
    //         if(istrue==true)
    //         result.Add(arr[i]);
    //     }
    //     foreach(int i in result)
    //     Console.Write(i+" ");

    // //unique element
    // int[] arr={1,2,3,1,4,3,2,7,2};
    // int[] result=new int[arr.Length];
    // int count=0;

    // for(int i = 0; i < arr.Length; i++)
    //     {
    //         bool istrue=true;
    //         for(int j = 0; j < arr.Length; j++)
    //         {
    //             if(arr[i]==arr[j]&& i!=j){
    //             istrue=false;    
    //             break;
    //             }
    //         }
    //         if(istrue==true){
    //         result[count]=arr[i];
    //         count++;
    //         }
    //     }
    //     for(int i=0;i<count;i++)
    //     Console.Write(result[i]+" ");

    //duplicate element
    // int[] arr={1,2,3,1,4,3,2,7,2};
    // int[] result=new int[arr.Length];
    // int count=0;

    // for(int i = 0; i < arr.Length; i++)
    //     {
    //         bool istrue=true;
    //         for(int j = 0; j < arr.Length; j++)
    //         {
    //             if(arr[i]==arr[j]&& i!=j){
    //             istrue=false;    
    //             break;
    //             }
    //         }
    //         if(istrue==false){
    //             for(int k = 0; k < result.Length; k++)
    //             {
    //                 if(result[k]==arr[i])
    //                 istrue=true;
    //             }
    //         if(istrue==false){
    //         result[count]=arr[i];
    //         count++;
    //             }
    //         }
    //     }
    //     for(int i=0;i<count;i++)
    //     Console.Write(result[i]+" ");

     //================concepts==============================
    // int[] arr=new int[6]{2,6,5,3,1,9};
    // Console.WriteLine(arr.GetValue(3));
    // Console.WriteLine(Array.IndexOf(arr,9));
    // Console.WriteLine(arr.IsReadOnly);
    // Console.WriteLine(arr.Rank);
    // Console.WriteLine(arr.IsFixedSize);
    // Console.Write("Before sorting: ");
    // for(int i = 0; i < arr.Length; i++)
    //     {
    //         Console.Write(arr[i]+" ");
    //     }
    // Array.Sort(arr);
    // Console.WriteLine("\n");
    // Console.Write("After Sorting: ");
    // for(int i = 0; i < arr.Length; i++)
    //     {
    //         Console.Write(arr[i]+" ");
    //     }
    // Array.Reverse(arr);
    // Console.WriteLine("\n");
    // Console.Write("After Reversing: ");
    // for(int i = 0; i < arr.Length; i++)
    //     {
    //         Console.Write(arr[i]+" ");
    //     }
     //=========================Employee.cs==================================
     Employee employee1=new Employee(){ID=30,Name="Harsh"};
     Employee employee2=new Employee(){ID=80,Name="Vivek"};
     Employee employee3=new Employee(){ID=50,Name="Arsh"};
     Employee employee4=new Employee(){ID=40,Name="Vansh"};
     Employee employee5=new Employee(){ID=10,Name="Shubham"};
     Employee[] employeeList=new Employee[5];
     employeeList[0]=employee1;
     employeeList[1]=employee2;
     employeeList[2]=employee3;
     employeeList[3]=employee4;
     employeeList[4]=employee5;

     Console.WriteLine("Before sorting: ");
     foreach(Employee e in employeeList)
        {
            Console.WriteLine(e);
        }
        Array.Sort(employeeList);
        Console.WriteLine("After sorting: ");
     foreach(Employee e in employeeList)
        {
            Console.WriteLine(e);
        }

      Console.WriteLine("\n\n\n");
     Program program=new Program();
     Employee employee =new Employee
     {
         ID=90,
         Name="HArsh Singh"
     };
     program.PassObject(employee);
     Employee employee6=program.ReturnObject();
     Console.WriteLine(employee6);
     Console.WriteLine("\n\n");
     program.PassArrayObject(employeeList);
     
    }
    public void PassObject(Employee employee)
    {
        Console.WriteLine(employee);
    }
    public Employee ReturnObject()
    {
        Employee employee=new Employee
        {
            ID=120,
            Name="Suresh"
        };
        return employee;
    }

    public void PassArrayObject(Employee[] employee)
    {
        foreach(Employee e in employee)
        {
            Console.WriteLine(e);
        }
    }
}