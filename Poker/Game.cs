using System;
namespace Poker
{
    public class Game
    {
        private Player[] players;

        public Game()
        {
            Console.WriteLine("How many players?");
            int playersinput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < (playersinput + 1); i++)
            {
                Console.WriteLine("Player name?");
                string playername = Console.ReadLine();
                Player player = new Player(playername);
                players[i] = player;
            }

            Shuffle shuffle = new Shuffle(players);

            // Ended here .. This shuffle the cards.
        }
    }
}
