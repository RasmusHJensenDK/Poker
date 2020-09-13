using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class DeckofCards
    {
        public numerical numericalValue;
        public suits suitsValue;
        private Card[] Deck;
        public DeckofCards()
        {
            this.Deck = new Card[52];

            int ti = 0;

            foreach (suits tt in Enum.GetValues(typeof(suits)))
            {
                foreach (numerical ss in Enum.GetValues(typeof(numerical)))
                {
                        Card newcard = new Card(tt, ss);
                        Deck[ti] = newcard;
                        ti++;
                }
            }
        }

        public Card[] GetDeck()
        {
            return this.Deck;
        }

        public Card DrawCard()
        {
            Random random = new Random();
            int index = random.Next(0, (Deck.Length - 1));
            return Deck[index];
        }
    }
}
