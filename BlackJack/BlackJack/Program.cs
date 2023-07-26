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

            Console.WriteLine("How much money did you bring to spend?");
            int playermoney = Convert.ToInt32(Console.ReadLine());

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
                    game.Play();
                }
                game -= player;
                Console.WriteLine("thank you for playing");
            }
            Console.WriteLine("feel free to look around the casino");
            Console.ReadLine();
        }
    }
}
