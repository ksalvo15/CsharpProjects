﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Player
    {
        public Player (string name, int beginBalance)
        {
            Hand = new List<Card>();
            Balance = beginBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("you do not have enough money for that bet");
            }
            else
            {
                Balance -= amount;
                    return true;
            }
        }


        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
}