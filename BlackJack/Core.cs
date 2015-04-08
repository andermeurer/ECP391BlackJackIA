using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJackGUI;
using System.Diagnostics;

namespace BlackJack
{
    public class Core
    {
        public static int AnalyzeHandValue(List<BlackJack.Card> cardListHand)
        {
            int handValue = 0;
            int maxValue = 21;
            
            // Soma das cartas comuns
            foreach (Card item in cardListHand.Where(item => item.cardnum != Enumerator.CardNumType.AS))
            {
                List<int> values = item.GetValue();
                handValue += values.First();
            }

            foreach (Card item in cardListHand.Where(item => item.cardnum == Enumerator.CardNumType.AS))
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

            return handValue;
        }


        internal static bool AnalyzeIAValue(List<Card> list)
        {
            throw new NotImplementedException();
        }
    }
}
