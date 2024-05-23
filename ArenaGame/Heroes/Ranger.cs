using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Ranger : Hero
    {
        private double dodgeChance;

        public Ranger(string name, double armor, double strength, Weapon weapon)
            : base(name, armor, strength, weapon)
        {
            dodgeChance = 0.05;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            return damage * 1.2; // Bonus for precision attacks
        }

        public override double Defend(double damage)
        {
            double probability = random.NextDouble();
            if (probability < dodgeChance)
            {
                return 0; // Successful dodge
            }
            return base.Defend(damage);
        }
    }
}
