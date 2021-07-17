using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class PaladinCreator : HeroCreator
    {

        private string name;

        public PaladinCreator(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Paladin(this.name);
        }
    }
}
