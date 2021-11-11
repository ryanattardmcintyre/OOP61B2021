using System;
using System.Collections.Generic;
using System.Text;

namespace Week6_Worksheet6_Question3
{
    class Warrior: Character
    {
        public Warrior ():base (300, 0, 120)
        {

        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
        }
    }
}
