using System;
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic Animal Sound");
    }
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dogs Bark");
    }
}
class Cat: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meow");
    }
}