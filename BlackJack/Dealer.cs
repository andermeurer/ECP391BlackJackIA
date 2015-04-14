using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        private List<Card> CardList = new List<Card>();

        public List<Card> GetCardList()
        {
            return CardList;
        }

        public void AddCard(Card card)
        {
            CardList.Add(card);
        }

        public int GetHandValue()
        {
            return Core.AnalyzeHandValue(CardList);
        }

        public bool Play(Deck deck, Player player, Dealer dealer)
        {
            bool continueHit = true;

            if (player.GetHandValue() == 21)
            {
                while (dealer.GetHandValue() < 21)
                {
                    dealer.AddCard(deck.HitCard());
                }

                if (dealer.GetHandValue() > 21)
                    return false;
            }
            else
            {
                
                while (dealer.GetHandValue() < 21 && continueHit)
                {
                    dealer.AddCard(deck.HitCard());
                    continueHit = Core.AnalyzeIAValue(deck, dealer, player.GetCardList().Count);
                }

                if (dealer.GetHandValue() < player.GetHandValue() ||
                    dealer.GetHandValue() > 21)
                    return false;

            }

            return true;
        }
    }
}
