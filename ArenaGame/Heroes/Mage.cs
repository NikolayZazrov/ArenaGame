using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Mage : Hero
    {
        private double mana;
        private double magicDamageMultiplier;

        public Mage(string name, double armor, double strength, Weapon weapon)
            : base(name, armor, strength, weapon)
        {
            mana = 100;
            magicDamageMultiplier = 1.2;
        }

        public override double Attack()
        {
            if (mana >= 20)
            {
                mana -= 20;
                double damage = base.Attack() * magicDamageMultiplier;
                return damage;
            }
            else
            {
                return base.Attack();
            }
        }

        public override double Defend(double damage)
        {
            double reducedDamage = base.Defend(damage);
            if (mana < 100)
            {
                mana += 10;
            }
            return reducedDamage;
        }
    }
}
