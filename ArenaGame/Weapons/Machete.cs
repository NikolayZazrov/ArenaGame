using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Machete : Weapon
    {
        public Machete(string name, double attackDamage, double damageMultiplier, double blockingPower)
            : base(name, attackDamage, damageMultiplier, blockingPower)
        {
            UniqueAttacks.AddRange(new string[] { "Chop", "Slash", "Hack", "Cleaving Strike", "Backhand Swing" });
        }
    }
}
