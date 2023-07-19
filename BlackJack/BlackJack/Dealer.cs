using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace BlackJack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString());
            Console.WriteLine(card + "\n");
            Deck.Cards.RemoveAt(0);
        }

    }
}
