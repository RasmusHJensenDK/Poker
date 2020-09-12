using System;
namespace Poker
{
    public class Player
    {
        private bool playerturn { get; set; }
        private string playername;
        Card[] playercards;

        public Player(string playername, bool playerturn = false)
        {
            this.playername = playername;
            this.playerturn = playerturn;
        }

        public void AddPlayerCard(Card card)
        {
            playercards[0] = card;
        }

        public void AddSecondCard(Card card)
        {
            playercards[1] = card;
        }
    }
}
