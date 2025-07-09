using System;
using System.Collections.Generic;

namespace ConsoleUI;

public abstract class Vehicle
{
    public int Year { get; set; } = 1993;
    public string Make { get; set; } = "Honda";
    public string Model { get; set; } = "Civic";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine($"This {GetType().Name} is virtually in drive!");
    }
}