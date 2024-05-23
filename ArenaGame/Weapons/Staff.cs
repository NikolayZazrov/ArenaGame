using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Staff : Weapon
    {
        public Staff(string name, double attackDamage, double damageMultiplier, double blockingPower)
            : base(name, attackDamage, damageMultiplier, blockingPower)
        {
            UniqueAttacks.AddRange(new string[] { "Thrust", "Sweep", "Spin Attack", "Overhead Smash", "Jab" });
        }
    }
}
