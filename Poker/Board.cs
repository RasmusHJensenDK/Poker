using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Board
    {
        private Shuffle shuffle;
        private bool flop = false;
        private bool turn = false;
        private bool river = false;
        public Board(Shuffle shuffle)
        {
            this.shuffle = shuffle;
        }

        public void Drawboard()
        {
            Console.WriteLine("********************** BOARD **********************");
            Console.WriteLine("Card flop :");
            if (flop)
            {
                foreach (Card card in shuffle.Flop())
                {
                    Console.WriteLine(card.Getnumerical() + " of " + card.GetSuits());
                }
            }
            //::PRINT TURN TO CONSOLE:://
            Console.WriteLine("Card turn :");
            if (turn)
            {
                foreach (Card card in shuffle.Turn())
                {
                    Console.WriteLine(card.Getnumerical() + " of " + card.GetSuits());
                }
            }
            //::PRINT RIVER TO CONSOLE:://
            Console.WriteLine("Card river :");
            if (river)
            {
                foreach (Card card in shuffle.River())
                {
                    Console.WriteLine(card.Getnumerical() + " of " + card.GetSuits());
                }
            }
        }

        public void SetFlop(bool setflop)
        {
            flop = setflop;
        }
        public void SetTurn(bool setturn)
        {
            turn = setturn;
        }
        public void SetRiver(bool setriver)
        {

        }
    }
}
