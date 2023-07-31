using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Casino;
using Casino.BlackJack;
using System.Data.SqlClient;
using System.Data;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grand hotel and casino. Tell us your name");
            string playername = Console.ReadLine();
            if (playername.ToLower() == "admin")
            {
                List<EntityException> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + "|");
                    Console.Write(exception.ExceptionType + "|");
                    Console.Write(exception.ExceptionMessage + "|");
                    Console.Write(exception.TimeStamp + "|");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

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
                    catch(Fraud ex)
                    {
                        Console.WriteLine("Security kick this person out");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("an error occured please contact support");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("thank you for playing");
            }
            Console.WriteLine("feel free to look around the casino");
            Console.ReadLine();
        }
        private static void UpdateDBWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog =
                                      BlackjackGame; Integrated Security = True; Connect Timeout = 30;
                                      Encrypt = False; TrustServerCertificate = False; ApplicationIntent =
                                      ReadWrite; MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<EntityException> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog =
                                      BlackjackGame; Integrated Security = True; Connect Timeout = 30;
                                      Encrypt = False; TrustServerCertificate = False; ApplicationIntent =
                                      ReadWrite; MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<EntityException> Exceptions = new List<EntityException>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EntityException exception = new EntityException();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
