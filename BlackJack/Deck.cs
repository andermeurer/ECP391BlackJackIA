using BlackJack.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        internal List<Card> deckCards;
        internal List<Card> usedCards;

        public Deck()
        {
            BuildDeck();
        }

        private void BuildDeck()
        {
            deckCards = new List<Card>();
            usedCards = new List<Card>();

            var valuesNaipes = Enum.GetValues(typeof(NaipeType));
            var valuesCards = Enum.GetValues(typeof(CardNumType));

            foreach (CardNumType vlCard in valuesCards)
            {
                foreach (NaipeType vlNaipe in valuesNaipes)
                {
                    this.deckCards.Add(new Card(vlNaipe, vlCard));
                }
            }

            this.Shuffle();
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = deckCards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = deckCards[k];
                deckCards[k] = deckCards[n];
                deckCards[n] = card;
            }  
        }

        public Card HitCard()
        {
            if (deckCards.Count <= 0)
                return null;

            Card cardReturn = deckCards.First();

            this.deckCards.Remove(cardReturn);
            this.usedCards.Add(cardReturn);

            return cardReturn;
        }

        public List<Card> listCards()
        {
            return deckCards;
        }

        public List<Card> listUsedCards()
        {
            return usedCards;
        }
    }
}
