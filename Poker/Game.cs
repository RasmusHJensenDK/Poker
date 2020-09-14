using System;
using System.Collections.Generic;

namespace Poker
{
    public class Game
    {
        private Player[] Players;
        private Bet[] betspreflopbets;
        private bool firstBettingRound = true;
        private Pot Potsize;

        public Game()
        {
//::ON BOARDING GAME::// !! SHOULD THERE BE AN OBJECT FOR THIS !!
            Console.WriteLine("How many players?");
            int playersinput = Convert.ToInt32(Console.ReadLine());

            this.Players = new Player[playersinput];
            this.betspreflopbets = new Bet[20];
            this.Potsize = new Pot(0);

//::ADD PLAYERS:://
            for (int i = 0; i < playersinput; i++)
            {
                Console.WriteLine("Player name?");
                string playername = Console.ReadLine();

                Player player = new Player(playername, 5000);
                Players[i] = player;
            }

//::SHUFFLE DECK:://
            Console.WriteLine("Shuffling");
            Shuffle shuffle = new Shuffle(Players);
            shuffle.Shuffecards();
            Console.WriteLine("Done");
            int controller = 0;
//::ALL PLAYERS TURN:://
            do
            {
                foreach(Player player in Players)
                {
//::ADD: ADD SWITCH FOR PRE-FLOP, FLOP, TURN, RIVER:://
                    int i = 0;
                    Console.WriteLine("Player " + player.GetPlayerName() + " press R to see your cards");
                    char r = Console.ReadKey().KeyChar;
//::CONFIDINIALLITY - HIDE PLAYERS CARD UNTIL PLAYER PRESS R:://     
                    while (r != 'R')
                    {
                        Console.WriteLine("Press R to see your cards " + player.GetPlayerName());
                        r = Console.ReadKey().KeyChar;
                    }
 //::GET ALL PLAYERS AND THEIR CASH:://                   
                    Console.Clear();
                    Console.WriteLine("************** PRE FLOP BETTING ROUND **************");
                    foreach(Player playertoconsole in Players)
                    {
                        Console.WriteLine("Player " + i.ToString() + " : " + Players[i].GetPlayerName() + " Money : " + Players[0].GetPlayerMoney());
                        i++;
                    }
//::PRINT FLOP TO CONSOLE:://
                    Console.WriteLine();
                    Console.WriteLine("********************** BOARD **********************");
                    Console.WriteLine("Card flop :");
                    foreach(Card card in shuffle.Flop())
                    {
                        Console.WriteLine(card.Getnumerical() + " of " + card.GetSuits());
                    }
//::PRINT TURN TO CONSOLE:://
                    Console.WriteLine("Card turn :");
                    foreach (Card card in shuffle.Turn())
                    {
                        Console.WriteLine(card.Getnumerical() + " of " + card.GetSuits());
                    }
//::PRINT RIVER TO CONSOLE:://
                    Console.WriteLine("Card river :");
                    foreach (Card card in shuffle.River())
                    {
                        Console.WriteLine(card.Getnumerical() + " of " + card.GetSuits());
                    }
//::PLAYER MOVE:://
                    Console.WriteLine();
                    Console.WriteLine("***************** PLAYER " + player.GetPlayerName() + " *****************");
                    Console.WriteLine("Cards:");
                    Console.WriteLine("-------------");
                    Console.WriteLine(player.ReturnCard(0).Getnumerical() + " of " + player.ReturnCard(0).GetSuits());
                    Console.WriteLine(player.ReturnCard(1).Getnumerical() + " of " + player.ReturnCard(1).GetSuits());
                    Console.WriteLine("************** PRE FLOP BETTING ROUND **************");
//::CHECK IF FOLD IS AN OPTION:://
                    Console.WriteLine("(B)et (C)heck or (F)old?");
                    char BCF = Console.ReadKey().KeyChar;

                    if(Potsize.Returnpotsize() != 0)
                    {
                        while(BCF != 'B' || BCF != 'F')
                        {
                            Console.WriteLine("Check is not an option, please fold or bet");
                            BCF = Console.ReadKey().KeyChar;
                        }
                    }

                    switch (BCF)
                    {
                        case 'B':
                            Console.WriteLine("Please enter bet");
//::CHECK IF BET IS HIGHER THAN LAST AND CHECK ACCOUNT BALANCE:://
                            int betpreflop = Convert.ToInt32(Console.ReadLine());

                            if(betpreflop > player.GetPlayerMoney())
                            {
                                Console.WriteLine("Youre too broke..");
                            }

                            Bet bet = new Bet(player, betpreflop);

                            Potsize.Addtopot(betpreflop);
                           
                            betspreflopbets[controller] = bet;

                            player.SetPlayerMoney(player.GetPlayerMoney() - betpreflop);

                            controller++;
                            
                            Console.Clear();
                            break;
                        case 'C':
                            Console.Clear();
                            break;
                        case 'F':
                            Console.Clear();
                            break;
                    }
                }
            } while (!firstBettingRound);
        }
    }
}

