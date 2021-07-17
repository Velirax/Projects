using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double litersPerKM, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }
            LitersPerKM = litersPerKM;
            TankCapacity = tankCapacity;
        }

       
        public double FuelQuantity { get; set; }
      

        public virtual double LitersPerKM { get; private set; }

        public double TankCapacity { get; private set; }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
        public virtual void Drive(double distance)
        {

            double litersNeeded = distance * this.LitersPerKM;
            if (this.FuelQuantity > litersNeeded)
            {
                this.FuelQuantity -= litersNeeded;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }

        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + liters > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }

        }

    }
}
