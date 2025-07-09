using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * DONE - Create an abstract class called Vehicle
             * DONE - The vehicle class shall have three string properties: Year, Make, and Model
             * DONE - Set the defaults of the properties to something generic in the Vehicle class
             * DONE - Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * DONE - Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE - Create a list of Vehicle called vehicles
            
            var vehicles = new List<Vehicle>();

            /*
             * DONE - Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * DONE - Set the properties values with object initializer syntax
             */

            var civic = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 1993 };
            var harley = new Motorcycle()
                { HasSideCart = true, Make = "Harley-Davidson", Model = "Fat Boy", Year = 1990 };

            Vehicle sedan = new Car() { Make = "Ford", Model = "Taurus", Year = 1986 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Lamborghini", Model = "Diablo", Year = 2001 };

            /*
             * DONE - Add the 4 vehicles to the list
             * DONE - Using a foreach loop iterate through the list and display each of the properties
             */
            
            vehicles.Add(civic);
            vehicles.Add(harley);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Year: {vehicle.Year}");
                vehicle.DriveAbstract();
                Console.WriteLine("------------------------");
            }

            // DONE - Call each of the drive methods for one car and one motorcycle

            civic.DriveAbstract();
            civic.DriveVirtual();
            harley.DriveAbstract();
            harley.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
