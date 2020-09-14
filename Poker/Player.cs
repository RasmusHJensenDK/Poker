using System;
namespace Poker
{
    public class Player
    {
        private bool playerturn { get; set; }
        private string playername;
        private int playermoney;
        private Bet bet;
        Card[] playercards = new Card[2];

        public Player(string playername, int playermoney, bool playerturn = false)
        {
            this.playername = playername;
            this.playermoney = playermoney;
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

        public int GetPlayerMoney()
        {
            return playermoney;
        }

        public void SetPlayerMoney(int i)
        {
            playermoney = (playermoney - i);
        }

        public Bet GetBet()
        {
            return bet;
        }

        public void SetBet(Bet betplayer)
        {
            bet = betplayer;
        }
    }
}
