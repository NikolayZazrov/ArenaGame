using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Sword : Weapon
    { 
        public Sword(string name, double attackDamage, double damageMultiplier, double blockingPower)
            : base (name, attackDamage, damageMultiplier, blockingPower)
        {
            this.UniqueAttacks.AddRange(new string[]{"Slash", "Slice", "Split"});
        }
    }
}
