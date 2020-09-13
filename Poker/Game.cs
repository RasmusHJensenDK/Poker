using System;
using System.Collections.Generic;

namespace Poker
{
    public class Game
    {
        private Player[] Players;

        public Game()
        {
            Console.WriteLine("How many players?");
            int playersinput = Convert.ToInt32(Console.ReadLine());

            this.Players = new Player[playersinput];

            for (int i = 0; i < playersinput; i++)
            {
                Console.WriteLine("Player name?");
                string playername = Console.ReadLine();

                Player player = new Player(playername);
                Players[i] = player;
            }

            Console.WriteLine("Shuffling");
            Shuffle shuffle = new Shuffle(Players);
            shuffle.Shuffecards();
            Console.WriteLine("Done");

            /*
            int ti = 0;
            foreach (Card obj in shuffle.Cardsinplay())
            {
                //Console.WriteLine(obj.Getnumerical().ToString() + " of " + obj.GetSuits().ToString());
                Console.WriteLine(Players[ti].GetPlayerName().ToString());
                Console.WriteLine(Players[ti].ReturnCard(0).ToString());
                ti++;
            }
            */
            Console.WriteLine(Players[2].ReturnCard(1).ToString() + " Card ");
        }
    }
}

