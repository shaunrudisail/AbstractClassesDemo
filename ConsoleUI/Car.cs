using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public Car()
    {
        
    }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("Car drives!");
    }

    public bool HasTrunk { get; set; } = true;
}