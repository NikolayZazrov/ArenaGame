using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; set; }

        private double damageMultiplier;
        public double DamageMultiplier 
        {
            get { return damageMultiplier; }

            set
            {
                double maxValue = 5, minValue = 0;

                if (value < minValue) damageMultiplier = minValue;
                else if (value > maxValue) damageMultiplier = maxValue;
                else damageMultiplier = value;
            }
        }
        public double BlockingPower { get; set; }

        public List<string> UniqueAttacks {  get; set; }

        public Weapon(string name, double attackDamage, double damageMultiplier, double blockingPower)
        {
            Name = name;
            AttackDamage = attackDamage;
            DamageMultiplier = damageMultiplier;
            BlockingPower = blockingPower;
            UniqueAttacks = new List<string>();
        }
    }
}
