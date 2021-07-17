using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKM, double tankCapacity) : base(fuelQuantity, litersPerKM , tankCapacity)
        {

        }
        public const double AirConditioning = 1.4;
        public bool IsEmpty { get; set; }

        public override double LitersPerKM => this.IsEmpty ? base.LitersPerKM : base.LitersPerKM + AirConditioning;

    }
}
