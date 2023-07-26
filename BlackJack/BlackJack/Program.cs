using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Casino;
using Casino.BlackJack;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grand hotel and casino. Tell us your name");
            string playername = Console.ReadLine();

            bool validAnswer = false;
            int playermoney = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring?");
                validAnswer = int.TryParse(Console.ReadLine(), out playermoney);
                if (!validAnswer) Console.WriteLine("please enter digits only no decimals");
            }

            Console.WriteLine("Hello {0} would you like to join a game of Blackjack?", playername);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playername, playermoney);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\kelse\Desktop\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new BlackjackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(Fraud)
                    {
                        Console.WriteLine("Security kick this person out");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("an error occured please contact support");
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("thank you for playing");
            }
            Console.WriteLine("feel free to look around the casino");
            Console.ReadLine();
        }
    }
}
