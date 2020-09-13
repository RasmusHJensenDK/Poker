using System;
namespace Poker
{
    public class Bet
    {
        private int playerbet;
        Player player;

        public Bet(Player player, int playerbet)
        {
            this.player = player;
            this.playerbet = playerbet;
        }

        public Player ReturnPlayer()
        {
            return player;
        }

        public int GetBet()
        {
            return playerbet;
        }
    }
}
