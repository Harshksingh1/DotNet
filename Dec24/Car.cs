using System;
class Car:Vehicle //created a child class from base class vehical
{  
    //calling base class constructor in derive class
    public Car(double distance,double hour,double fuel) : base(distance, hour, fuel)
    {
        
    }
    public override void Average()
    {
        double avg=distance/fuel;
        Console.WriteLine("the avg of vehicle is: "+avg);
    }
     public override void Speed(){
        double speed=distance/hour;
        Console.WriteLine("the Speed of vehicle is: "+speed);
    }
} 
