using System;
using System.Linq;
using System.Net.Security;
using Microsoft.VisualBasic;
using System.Data;

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
// }
class Program
{
    public static void Main(string[] args)
    {
        //Data source
        // string[] names={"Bill","steve","James","Msdf"};
        //write the query
        // IEnumerable<string> names=
        // var name=from s in names
        //           where s.Contains('a')
        //           select s;

        //Method Syntax (a shorter way to write above code)
        // var name=names.Where(s=>s.Contains('a'));
        //execute the query
        // foreach(string s in name)
        // {
        //     Console.WriteLine(s);
        // }



        // IList<string> stringList=new List<string>()
        // {
        //     "C# Tutorials",
        //     "MVC Tutorials",
        //     "C#",
        //     "Java",
        //     "VB.NET Tutorials"
        // };
        // var result=from s in stringList
        //           where s.Contains("Tutorials")
        //           select s;
        // foreach(var str in result)
        // {
        //     Console.WriteLine(str);
        // }   


        // IList<Student> studentList=new List<Student>()
        // {
        //     new Student(){Id=1,Name="Harsh",Age=12},
        //     new Student(){Id=2,Name="Abhi",Age=14},
        //     new Student(){Id=3,Name="Mohan",Age=25},
        //     new Student(){Id=4,Name="Ravi",Age=28},
        //     new Student(){Id=5,Name="Rakesh",Age=41},
        // };  
        // //Query syntax   
        // var students=from s in studentList
        //              where s.Age>12 && s.Age<20 
        //              select s;
        // //Method syntax             
        // var studentss=studentList.Where(s=>s.Age>12 && s.Age<20);
        // Console.WriteLine("Following students are teenagers");
        // foreach(Student stud in studentss)
        // {
        //     Console.WriteLine($"|Id:{stud.Id}|Name:{stud.Name}|Age:{stud.Age}|");
        // }


        var employees=new Employee(); //create a instance of Employees datatable
        //Add rows to the data table
        employees.Rows.Add(1,"Harsh",30,"IT",2340987);
        employees.Rows.Add(2,"Raj",40,"Finance",232233);
        employees.Rows.Add(3,"Rajesh",60,"Production",133487);
        employees.Rows.Add(4,"Gopal",20,"IT",2234987);
        employees.Rows.Add(5,"Naresh",30,"IT",3340987);
    
    var query=from emp in employees.AsEnumerable()
    where emp.Field<string>("Department")=="IT"
    orderby emp.Field<int>("Salary") descending
    select new
    {
        Id=emp.Field<int>("Id"),
        Name=emp.Field<string>("Name"),
        Age=emp.Field<int>("Age"),
        Department=emp.Field<string>("Department"),
        Salary=emp.Field<int>("Salary"),
    };
    foreach (var item in query){
        Console.WriteLine($"Id: {item.Id},Name: {item.Name},Age: {item.Age},Department: {item.Department}, Salary:{item.Salary}");
    }
}
}