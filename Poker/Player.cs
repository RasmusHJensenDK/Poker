using System;
namespace Poker
{
    public class Player
    {
        private bool playerturn { get; set; }
        private string playername;
        Card[] playercards = new Card[2];

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

        public Card ReturnCard(int i)
        {
            return playercards[i];
        }

        public string GetPlayerName()
        {
            return playername;
        }
    }
}
