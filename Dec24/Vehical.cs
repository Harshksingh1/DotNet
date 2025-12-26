using System;
class Vehicle{
    protected double distance;
    protected double hour;
    protected double fuel;
    public Vehicle(double distance,double hour,double fuel){
        this.distance=distance;
        this.hour=hour;
        this.fuel=fuel;
    }
    public virtual void Average(){
        double avg=distance/fuel;
        Console.WriteLine("the avg of vehicle is: "+avg);
    }
    public virtual void Speed(){
        double speed=distance/hour;
        Console.WriteLine("the Speed of vehicle is: "+speed);
    }
}