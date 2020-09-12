using System;
using System.Collections.Generic;

namespace Poker
{
    public class Shuffle
    {
        public bool gameisdone = false;
        DeckofCards deck = new DeckofCards();
        List<object> cardsinplay = new List<object>();
        List<object> flopturnriver = new List<object>();

        public Shuffle(Player[] players)
        {
            do
            {
                for(int i = 0; i < 2; i++)
                {
                    foreach (Player player in players)
                    {
                        Card card = deck.DrawCard();

                        while(!cardsinplay.Contains(card))
                        {
                            card = deck.DrawCard();
                        }

                        if(i == 1)
                        {
                            player.AddSecondCard(card);
                        }

                        player.AddPlayerCard(card);
                        cardsinplay.Add(card);
                    }
                }

                for(int i = 0; i < 6; i++) 
                {
                    Card card = deck.DrawCard();
                    while(!cardsinplay.Contains(card))
                    {
                        card = deck.DrawCard();
                    }
                    cardsinplay.Add(card);
                    flopturnriver.Add(card);
                }

            } while (!gameisdone);
        }
    }
}