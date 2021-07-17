using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
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
                Weight += 0.25 * food.Quantity;
            }
        }
    }

}