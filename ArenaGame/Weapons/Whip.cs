using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Whip : Weapon
    {
        public Whip(string name, double attackDamage, double damageMultiplier, double blockingPower)
            : base(name, attackDamage, damageMultiplier, blockingPower)
        {
            UniqueAttacks.AddRange(new string[] { "Lash", "Crack", "Wrap", "Flick", "Entangle" });
        }
    }
}
