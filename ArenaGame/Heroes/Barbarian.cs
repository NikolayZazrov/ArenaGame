using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Barbarian : Hero
    {
        public Barbarian(string name, double armor, double strength, Weapon weapon)
            : base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double rageBonus = 1 + ((100 - Health) / 100); // More damage as health decreases
            return damage * rageBonus;
        }

        public override double Defend(double damage)
        {
            double reducedDamage = base.Defend(damage);
            return reducedDamage * 1.1; // Takes more damage due to reckless defense
        }
    }
}
