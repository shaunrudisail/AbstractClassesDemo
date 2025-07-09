using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public Motorcycle()
    {
        
    }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle drives!");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that virtually drives!");
    }

    public bool HasSideCart { get; set; } = false;
}