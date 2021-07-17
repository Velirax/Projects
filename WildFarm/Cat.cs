using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Cat : Feline
    {
        public Cat(string name, double weight,  string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                FoodEaten += food.Quantity;
                Weight += 0.3 * food.Quantity;
            }
        }
    }
}
