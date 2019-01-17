using System;
using System.Collections.Generic;
using System.Linq;
using OpenSpeelkaarten.Structures.Cards;

namespace OpenSpeelkaarten.Structures.Stack
{
    class Deck:SLLStack<Card>
    {
        /// <summary>
        /// Creates a new deck.
        /// </summary>
        /// <param name="shuffle"> True for a shuffled deck else false.</param>
        public Deck(bool shuffle = true )
        {
            if (shuffle)
            {
                CreateCardDeck();
            }
            else
            {
                CreateCardDeck(false);
            }
        }

        private void CreateCardDeck(bool shuffle = true)
        {
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "B", "V", "K", "A" };
            string[] types = { "Ruiten", "Klaveren", "Harten", "Schoppen" };

            List<Card> cards = new List<Card>();


            foreach (string value in values)
            {
                foreach (string type in types)
                {
                    cards.Add(new Card(value, type));
                }
            }

            if (shuffle)
            {
                Random rnd = new Random();
                int i;

                while (cards.Count > 0)
                {
                    i = rnd.Next(cards.Count);
                    Push(cards.ElementAt(i));
                    cards.Remove(cards.ElementAt(i));
                }
            }
            else
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    Push(cards[i]);
                }
            }
        }
    }
}
