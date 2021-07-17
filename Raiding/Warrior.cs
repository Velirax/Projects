using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {

        }
        public override int Power => 100;
        public override void CastAbility()
        {
            Console.WriteLine($"{this.GetType().Name} - {base.Name} hit for {this.Power} damage");
        }
    }
}
