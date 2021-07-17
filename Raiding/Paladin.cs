using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        {

        }
        public override int Power => 100;
        public override void CastAbility()
        {
            Console.WriteLine($"{this.GetType().Name} - {base.Name} healed for {this.Power}");
        }
    }
}
