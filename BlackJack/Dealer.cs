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
    }
}
