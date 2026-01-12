using System.Data.Common;
class Student
{
    public int Id { get; set; }
    public string Name{get; set;}
    public int Age { get; set; }
}
delegate bool IsTeenAger(Student stud);
class Program
{
    public static void Main(string[] args)
    {
        Student student=new Student()
        {
            Id=101,
            Name="Harsh",
            Age=24

        };
        IsTeenAger isTeenAger=delegate(Student s)//Anonymous method
        {
            return s.Age>12 && s.Age<20;
        };
        //Lambda Expression
        IsTeenAger isTeenAger1=(s)=>{return s.Age>12 && s.Age<20;};
        Console.WriteLine(isTeenAger1(student));
        IsTeenAger isTeenAger2=s=>s.Age>12 && s.Age<20;
        Console.WriteLine(isTeenAger2(student));

        Console.WriteLine(isTeenAger(student));  //calling anonymous method
    }
}