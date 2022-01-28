using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    internal class Player
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + Cash + "isn't a valid amount.");

                return 0;
            }
            else if (amount > Cash)
            {
                Console.WriteLine(Name + " says: I don't have enough cash to give you " + amount + " bucks.");

                return 0;
            }

            Cash -= amount;

            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount i'll take.");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
