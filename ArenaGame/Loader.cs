using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using static System.Net.Mime.MediaTypeNames;

namespace ArenaGame
{
    public class Loader
    {
        protected static List<Weapon> LoadWeapons() 
        {
            var weapons = new List<Weapon>();

            weapons.Add(new Sword("Sword of Abaddon", 15, 1, 5));
            weapons.Add(new Dagger("Dagger of Betrayal", 20, 1.5, 0.5));
            weapons.Add(new Staff("Staff of Moses", 25, 1.2, 10));
            weapons.Add(new Whip("Whip of Doom", 18, 1.8, 0));
            weapons.Add(new Machete("Machete of the Mongols", 22, 1.4, 4));

            return weapons;
        }

        public static Dictionary<string, Hero> LoadHeroes()
        {
            
            var weapons = LoadWeapons();

            Sword defaultWeapon = new Sword("Rookie Sword", 5, 1.0, 0.2);

            var heroes = new Dictionary<string, Hero>()
            {
                { "Knight", new Knight("Sir Gallant (Knight)", 100, 50, weapons[0])},
                { "Assasin", new Assassin("Shadow (Assasin)", 80, 30, weapons[1])},
                { "Mage", new Mage("Merlin (Mage)", 60, 100, weapons[2])},
                { "Barabarian", new Barbarian("Conan (Barbarian)", 120, 20, weapons[4])},
                { "Ranger", new Ranger("Archer (Ranger)", 70, 40, weapons[3])}
            };

            return heroes;
        }

    }
}
