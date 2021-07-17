using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public virtual int FoodEaten { get;  set; }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            
        }
        public abstract void AskForFood();

        public abstract void EatFood(Food food);
    }
}
