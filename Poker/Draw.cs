using System;
using System.Collections.Generic;

namespace Poker
{
    public class Draw
    {
//:: IS THIS CLASS NESSECARY? IT IS NOT AN OBJECT :://
        DeckofCards deckofcards = new DeckofCards();
        List<object> cardsdrawn = new List<object>();

        public Draw()
        {

        }

        public void Drawcard()
        {
            Card card = deckofcards.DrawCard();

            while (!cardsdrawn.Contains(card))
            {
                card = deckofcards.DrawCard();
            }
            cardsdrawn.Add(card);
        }

        public List<object> ReturnList()
        {
            return cardsdrawn;
        }
    }
}