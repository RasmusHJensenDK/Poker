using System;
namespace Poker
{
    public enum suits { Clubs = 8, Hearts = 9, Diamonds = 10, Spades = 11, Joker = 0 };
    public enum numerical { Joker = 0, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13, Ace = 14 };

    public class Card
    {
        private string suits;
        private string numerical;
        public Card(suits suits, numerical numerical)
        {
            this.suits = suits.ToString();
            this.numerical = numerical.ToString();
        }

        public string GetCardColour()
        {
            return suits;
        }

        public string Getnumerical()
        {
            return numerical;
        }
    }
}
