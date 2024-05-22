using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : Weapon
    {
        public Dagger(string name, double attackDamage, double damageMultiplier, double blockingPower)
            : base(name, attackDamage, damageMultiplier, blockingPower)
        {
            this.UniqueAttacks.AddRange(new string[] { "Stab", "Cut", "Severe" });
        }
    }
}
