using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                try
                {
                    string[] animalTokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string[] foodTokens = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Animal animal = CreateAnimal(animalTokens);
                    Food food = CreateFood(foodTokens);

                    animals.Add(animal);
                    animal.AskForFood();
                    animal.EatFood(food);

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
        public static Animal CreateAnimal(string[] animalTokens)
        {
            string animalType = animalTokens[0];
            string name = animalTokens[1];
            double weight = double.Parse(animalTokens[2]);
            Animal animal = null;
            if (animalType == "Cat")
            {
                string livingRegion = animalTokens[3];
                string breed = animalTokens[4];
                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (animalType == "Tiger")
            {
                string livingRegion = animalTokens[3];
                string breed = animalTokens[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (animalType == "Owl")
            {
                double wingSize = double.Parse(animalTokens[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (animalType == "Hen")
            {
                double wingSize = double.Parse(animalTokens[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (animalType == "Mouse")
            {
                string livingRegion = animalTokens[3];
                animal = new Mouse(name, weight, livingRegion);
            }
            else if (animalType == "Dog")
            {
                string livingRegion = animalTokens[3];
                animal = new Dog(name, weight, livingRegion);
            }
            return animal;
        }

        public static Food CreateFood(string[] foodTokens)
        {
            Food food = null;
            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);
            if (foodType == "Vegetable")
            {
                food = new Vegetable(foodQuantity);
            }
            else if (foodType == "Fruit")
            {
                food = new Fruit(foodQuantity);
            }
            else if (foodType == "Meat")
            {
                food = new Meat(foodQuantity);
            }
            else if (foodType == "Seeds")
            {
                food = new Seeds(foodQuantity);
            }
            return food;
        }
    }

}