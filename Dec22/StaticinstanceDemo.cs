using System;
class StaticinstanceDemo
{
    public int var=0;   //instance variable
    public static int var1=10;  //static variable

    // public void count() //instance method
    // {
    //     var++;
    // }
    // public int Display()
    // {
    //     return var;
    // }

    public void count()   //static method
    {
        var1++;
    }
    public int Display()
    {
        return var1;
    }
}