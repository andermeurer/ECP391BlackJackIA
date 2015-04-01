using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Core
    {
        public static int AnalyzeHandValue(List<BlackJack.Card> cardListHand)
        {
            int handValue = 0;
            int maxValue = 21;
            
            List<int> handPossibList = new List<int>();

            // Remove AS da Soma das Cartas
            List<Card> aceList = cardListHand.Where(item => item.cardnum == Enumerator.CardNumType.AS).ToList();

            foreach (var item in aceList)
            {
                cardListHand.Remove(item);
            }

            // Soma das cartas comuns
            foreach (Card item in cardListHand)
            {
                List<int> values = item.GetValue();
                handValue += values.First();
            }

            // 8 + 3 = 11
            if (aceList.Count > 0)
            {
                foreach (var item in aceList)
                {
                    if (handValue + 11 <= maxValue)
                    {
                        handValue += 11;
                    }
                    else
                    {
                        handValue += 1;
                    }
                }
            }

            return handValue;
        }
    }
}
