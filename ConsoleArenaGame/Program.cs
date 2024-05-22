using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
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
            Sword heroAWeapon = new Sword("Sword of Abaddon", 15, 1, 5);
            Dagger heroBWeapon = new Dagger("Dagger of Betrayal", 20, 1.5, 0);

            GameEngine gameEngine = new GameEngine()
            { 
                HeroA = new Knight("Knight", 10, 20, heroAWeapon),
                HeroB = new Assassin("Assassin", 10, 5, heroBWeapon),
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}