using System;

namespace BettingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double odds = 0.75;

            Player player = new Player() { Name = "The player", Cash = 100 };

            Console.WriteLine("Welcome to the casino. The odds are " + odds + ".");


            while(player.Cash > 0)
            {
                player.WriteMyInfo();

                Console.Write("How much do you want to bet: ");

                string howMuch = Console.ReadLine();

                if (int.TryParse(howMuch, out int amount))
                {
                    player.GiveCash(amount);

                    int pot = 2 * amount;

                    if(random.NextDouble() > odds)
                    {
                        Console.WriteLine("You win " + pot + ".");

                        player.ReceiveCash(pot);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you lose.");
                    }
                }
            }

            Console.WriteLine("The house always wins.");
        }
    }
}
