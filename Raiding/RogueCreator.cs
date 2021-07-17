using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class RogueCreator : HeroCreator
    {
        private string name;

        public RogueCreator(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Rogue(this.name);
        }
    }
}
