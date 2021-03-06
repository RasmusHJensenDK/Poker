﻿using System;
using System.Collections.Generic;

namespace Poker
{
    public class Shuffle
    {
        DeckofCards deck = new DeckofCards();
        List<object> cardsinplay = new List<object>();
        List<object> flopturnriver = new List<object>();
        Player[] players;

        public Shuffle(Player[] players)
        {
            this.players = players;
        }

        public void Shuffecards()
        {
//Shuffle 1 card at a time to each player.
            for (int i = 0; i < 2; i++)
            {
                foreach (Player player in players)
                {
                    Card card = deck.DrawCard();
                    
                    while (cardsinplay.Contains(card))
                    {
                        card = deck.DrawCard();
                    }

                    switch(i)
                    {
                        case 0:
                            player.AddPlayerCard(card);
                            cardsinplay.Add(card);
                            break;
                        case 1:
                            player.AddSecondCard(card);
                            cardsinplay.Add(card);
                            break;
                        default: break;
                    }
                }
            }
//Shuffle for flop turn river
            for (int i = 0; i < 6; i++)
            {
                Card card = deck.DrawCard();
                while (!cardsinplay.Contains(card))
                {
                    card = deck.DrawCard();
                }
                cardsinplay.Add(card);
                flopturnriver.Add(card);
            }
        }

        public List<object> Cardsinplay()
        {
            return cardsinplay;
        }

    }
}