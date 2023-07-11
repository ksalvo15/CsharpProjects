﻿using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {            
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
        {
            Console.WriteLine(card.Face + " of " + card.Suit);
        }
        Console.WriteLine(deck.Cards.Count);
        Console.ReadLine();
    }
    }
}
