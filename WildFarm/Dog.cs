using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight,  string livingRegion) : base(name, weight, livingRegion)
        {

        }
        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                FoodEaten += food.Quantity;
                Weight += 0.4 * food.Quantity;
            }
        }
    }
}
