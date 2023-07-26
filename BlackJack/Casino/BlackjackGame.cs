using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.BlackJack
{
    public class BlackjackGame : Game, IWalkAway
    {
        public BlackjackDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new BlackjackDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bets");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}:", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool Blackjack = BlackjackRules.CheckforBlackjack(player.Hand);
                        if (Blackjack)
                        {
                            Console.WriteLine("Blackjack {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i==1)
                {
                    bool Blackjack = BlackjackRules.CheckforBlackjack(Dealer.Hand);
                    if (Blackjack)
                    {
                        Console.WriteLine("Dealer has Blackjack everyone loses");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cars are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\nHit or Stay");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackjackRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted you lose your bet of {1}, your balance in now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer =="yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
            Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting ... ");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is Busted");

                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    int winnings = entry.Value * 2;

                    Players.Where(x => x.Name == entry.Key.Name).First().Balance -= winnings;
                    Console.WriteLine("{0} won {1}, you have {2}", entry.Key.Name, entry.Value, winnings);                    
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = BlackjackRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon ==null)
                {
                    Console.WriteLine("push no one wins");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += Bets[player];
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer Wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack Players");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
