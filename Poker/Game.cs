using System;
using System.Collections.Generic;

namespace Poker
{
    public class Game
    {
        private Player[] Players;
        private Win[] win;
        private Bet[] betspreflopbets;
        private Bettinground bettinground;
        private bool firstBettingRound = false;
        private Pot Potsize;
        private int winningsplaceholder = 0;
        private char BCF;
        private int betinnumbers = 0;


        public Game()
        {
//::ON BOARDING GAME::// !! SHOULD THERE BE AN OBJECT FOR THIS !!
            Console.WriteLine("How many players?");
            int playersinput = Convert.ToInt32(Console.ReadLine());
            this.Players = new Player[playersinput];
            this.betspreflopbets = new Bet[20];
            this.win = new Win[3];
            this.Potsize = new Pot(0);
//::ADD PLAYERS:://
            for (int i = 0; i < playersinput; i++)
            {
                Console.WriteLine("Player name?");
                string playername = Console.ReadLine();

                Player player = new Player(playername, 5000);
                Players[i] = player;
            } 

//::NEW INSTATIENCE OF 2 OBJECTS:://
            Shuffle shuffle = new Shuffle(Players);
            Board board = new Board(shuffle);
            shuffle.Shuffecards();
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
                    Console.WriteLine("************** PLAYERS **************");
                    foreach(Player playertoconsole in Players)
                    {
                        if(i != 0)
                        {
                            if (Players[i].GetBet() != null)
                            {
                                Console.WriteLine("Player " + i.ToString() + " : " + Players[i].GetPlayerName() + " Money : " + Players[i].GetPlayerMoney() + "||" + "Bet : " + Players[i].GetBet().GetBet().ToString());
                            }
                        }
                        Console.WriteLine("Player " + i.ToString() + " : " + Players[i].GetPlayerName() + " Money : " + Players[i].GetPlayerMoney() + "||" + "Havent taken turn yet");
                        i++;
                    }
//::PRINT BOARD:://
                    board.Drawboard();
                    
//::PLAYER MOVE::// 
                    if(player.GetFolded())
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("***************** PLAYER " + player.GetPlayerName() + " *****************");
                    Console.WriteLine("Cards:");
                    Console.WriteLine("-------------");
                    Console.WriteLine(player.ReturnCard(0).Getnumerical() + " of " + player.ReturnCard(0).GetSuits());
                    Console.WriteLine(player.ReturnCard(1).Getnumerical() + " of " + player.ReturnCard(1).GetSuits());
                    Console.WriteLine("************** PRE FLOP BETTING ROUND **************");
//::CHECK IF CHECK IS AN OPTION:://
                    if (Potsize.Returnpotsize() == 0)
                    {
                        Console.WriteLine("(B)et, (C)heck or (F)old?");
                        BCF = Console.ReadKey().KeyChar;
                    }

                    if(Potsize.Returnpotsize() != 0)
                    {
                        Console.WriteLine("(R)aise, (C)all, (F)old?");
                        BCF = Console.ReadKey().KeyChar;
                    }

                    switch (BCF)
                    {
                        case 'B':
                            Console.WriteLine("Please enter bet");
                            betinnumbers = Convert.ToInt32(Console.ReadLine());
                            if(betinnumbers > player.GetPlayerMoney())
                            {
                                Console.WriteLine("Youre too broke..");
                            }
                            Bet bet = new Bet(player, betinnumbers);
                            Potsize.Addtopot(betinnumbers);
                            player.SetPlayerMoney(player.GetPlayerMoney() - bet.GetBet());
                            Console.Clear();
                            break;
                        case 'C':
                            //Two states Check OR Call
                            Console.Clear();
                            break;
                        case 'F':
                            player.SetFolded(true);
                            Console.Clear();
                            break;
                        case 'K':
                            Console.Clear();
                            break;
                    }
                }

                Win winni = new Win(0);
                winni.Addtowinnings(Potsize.Returnpotsize());
                win[winningsplaceholder] = winni;
                winningsplaceholder++;

            } while (!firstBettingRound);
        }
    }
}

