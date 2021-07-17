using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKM, double tankCapacity) : base(fuelQuantity, litersPerKM + 0.9, tankCapacity)
        {
            
        }
        
       
    }
}
