using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight,  string livingRegion, string breed) : base(name, weight,  livingRegion, breed)
        {

        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
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
                Weight += 1.00 * food.Quantity;
            }
        }
    }
}
