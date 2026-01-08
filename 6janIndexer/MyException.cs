using System;
class MyException:Exception
{
    public MyException(string str)
    {
        Console.WriteLine("user defined exception ");
    }
}