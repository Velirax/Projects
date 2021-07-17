using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKM, double tankCapacity) : base(fuelQuantity, litersPerKM + 1.6, tankCapacity)
        {
            
        }
       
        public override void Refuel(double liters)
        {
            if (base.FuelQuantity + liters > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                base.Refuel(liters * 0.95);
            }
        }
        

    }
}
