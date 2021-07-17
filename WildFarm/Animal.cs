using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public virtual int FoodEaten { get;  set; }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            
        public abstract void EatFood(Food food);
    }
}
