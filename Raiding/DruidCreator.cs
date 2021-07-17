using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class DruidCreator : HeroCreator
    {
        private string name;

        public DruidCreator(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Druid(this.name);
        }
    }
}
