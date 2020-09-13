using System;
using System.Collections.Generic;

namespace Poker
{
    public class Game
    {
        private Player[] Players;
        private bool firstBettingRound = true;

        public Game()
        {
            Console.WriteLine("How many players?");
            int playersinput = Convert.ToInt32(Console.ReadLine());

            this.Players = new Player[playersinput];
//::ADD PLAYERS:://
            for (int i = 0; i < playersinput; i++)
            {
                Console.WriteLine("Player name?");
                string playername = Console.ReadLine();

                Player player = new Player(playername);
                Players[i] = player;
            }

//::SHUFFLE DECK:://
            Console.WriteLine("Shuffling");
            Shuffle shuffle = new Shuffle(Players);
            shuffle.Shuffecards();
            Console.WriteLine("Done");

//::FIRST PLAYER TURN:://

            do
            {
                foreach(Player player in Players)
                {
                    Console.Clear();
                    Console.WriteLine("Player " + player.GetPlayerName());
                    Console.WriteLine("Cards:");
                    Console.WriteLine("-------------");
                    Console.WriteLine(player.ReturnCard(0).Getnumerical() + " of " + player.ReturnCard(0).GetSuits());
                    Console.WriteLine(player.ReturnCard(1).Getnumerical() + " of " + player.ReturnCard(1).GetSuits());
                    Console.WriteLine("-------------");
//::CHECK IF FOLD IS AN OPTION:://
                    Console.WriteLine("(B)et (C)heck or (F)old?");
                    char BCF = Console.ReadKey().KeyChar;

                    switch(BCF)
                    {
                        case 'B':
                            Console.WriteLine("Please enter bet");
//::BET - NEW OBJECT??:://
                            int betpreflop = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 'C':
                            break;
                        case 'F':
                            break;
                    }
                }
            } while (!firstBettingRound);
        }
    }
}

