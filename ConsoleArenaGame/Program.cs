using System.Net;
using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static string SelectRandomHeroClass(Dictionary<string, Hero> weapons)
        {
            Random random = new Random();

            return weapons.ElementAt(random.Next(0, weapons.Count)).Key;
        }

        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name}" +
                              $" with {Math.Round(args.Attack,2)} ({args.AttackUsed}" +
                              $" by the {args.Attacker.PlayerWeapon.Name})" +
                              $" and caused {Math.Round(args.Damage,2)} damage.");

            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            
            //Balancing needs to be done to the stats and abilities of the heroes and weapons
            var heroes = Loader.LoadHeroes();

            var heroA = heroes[SelectRandomHeroClass(heroes)];
            var heroB = heroes[SelectRandomHeroClass(heroes)];

            GameEngine gameEngine = new GameEngine()
            { 
                HeroA = heroA,
                HeroB = heroB,
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}