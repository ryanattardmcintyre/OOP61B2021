using System;
using System.Collections.Generic;
using System.Text;

namespace Week6_Worksheet6_Question3
{
    abstract class Character : IAttack
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }

        protected Character(int _health, int _mana, int _damage)
        {
            Health = _health;
            Mana = _mana;
            Damage = _damage;
        }

        public abstract void Attack(Character target);
    }
}
