using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; private set; }
        public double Armor { get; private set; }
        public double Strength { get; private set; }
        public Weapon PlayerWeapon { get; private set; }
        public string SpecialAttack {  get; private set; }
        public List<Weapon> Inventory { get; private set; }
        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public Hero(string name, double armor, double strength, Weapon weapon)
        {
            Health = 100;

            Name = name;
            Armor = armor;
            Strength = strength;
            PlayerWeapon = weapon;
        }

        public void AddToInventory(params Weapon[] weapons)
        {
            foreach (var weapon in weapons)
            {
                if (!Inventory.Contains(weapon))
                {
                    Inventory.Add(weapon);
                }
            }  
        }

        // returns actual damage
        public virtual double Attack()
        {
            double totalDamage = Strength + (PlayerWeapon.AttackDamage * PlayerWeapon.DamageMultiplier);
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);
            return realDamage;
        }

        public virtual double Defend(double damage)
        {
            double coef = random.Next(80, 120 + 1);
            double defendPower = (Armor + PlayerWeapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            Health -= realDamage;
            return realDamage;
        }

        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health,2)}";
        }
    }
}
