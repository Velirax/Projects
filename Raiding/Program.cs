using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> listOfHeroes = new List<BaseHero>();
            HeroCreator herocreator = null;
            while(listOfHeroes.Count < n)
            {
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();
                if (heroType == "Druid")
                {
                    herocreator = new DruidCreator(name);
                }
                else if (heroType == "Paladin")
                {
                    herocreator = new PaladinCreator(name);
                }
                else if (heroType == "Rogue")
                {
                    herocreator = new RogueCreator(name);
                }
                else if (heroType == "Warrior")
                {
                    herocreator = new WarriorCreator(name);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
                BaseHero hero = herocreator.CreateHero();
                listOfHeroes.Add(hero);
            }
            int powerOfBoss = int.Parse(Console.ReadLine());
            int powerOfHerous = 0;
            foreach (var hero in listOfHeroes)
            {
                hero.CastAbility();
                powerOfHerous += hero.Power;
            }
            if (powerOfHerous >= powerOfBoss)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
