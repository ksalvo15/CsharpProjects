using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }
        public string Dealer { get; set; }


        public abstract void Play();
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
