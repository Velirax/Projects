using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class WarriorCreator : HeroCreator
    {
        private string name;

        public WarriorCreator(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Warrior(this.name);
        }
    }
}
