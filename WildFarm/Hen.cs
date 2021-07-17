using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void EatFood(Food food)
        {
            FoodEaten += food.Quantity;
            Weight += 0.35 * food.Quantity;
        }



    }
}