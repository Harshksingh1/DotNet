using System;
class AddTwoNumbers
{
    public delegate void dg_OddNumber();
    public event dg_OddNumber ev_OddNumber;//Declared Events
    public void Add()
    {
        int result;
        result=5+4;
        Console.WriteLine(result.ToString());
        if(result%2!=0 && ev_OddNumber != null)
        {
            ev_OddNumber();//raised Event
        }
    }
}