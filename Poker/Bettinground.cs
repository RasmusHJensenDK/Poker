using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Bettinground
    {
        private Bet[] bets;
        private Player[] players;
        public Bettinground(Player[] players, Bet[] bets)
        {
            this.bets = bets;
            this.players = players;
        }

        public Bet[] Returnbets()
        {
            return bets;
        }
    }
}
