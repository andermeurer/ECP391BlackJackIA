using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJackGUI;
using System.Diagnostics;
using BlackJack.Enumerator;

namespace BlackJack
{
    public class Core
    {
        public static Func<Int64, Int64> Fatorial = x => x < 0 ? -1 : x == 1 || x == 0 ? 1 : x * Fatorial(x - 1);

        private Dictionary<int, DecisionType> decisionDict
        {
            get
            {
                Dictionary<int, DecisionType> dDict = new Dictionary<int, DecisionType>();

                dDict.Add(2, DecisionType.HIT);
                dDict.Add(3, DecisionType.HIT);
                dDict.Add(4, DecisionType.HIT);
                dDict.Add(5, DecisionType.HIT);
                dDict.Add(6, DecisionType.HIT);
                dDict.Add(7, DecisionType.HIT);

                return dDict;
            }
        }

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

        public static decimal getValueChance(int nx, int nv, int cardValue)
        {
            if (cardValue != 10)
                return ((4 - Convert.ToDecimal(nx)) / (52 - Convert.ToDecimal(nv))) * 100;
            else
                return ((16 - Convert.ToDecimal(nx)) / (52 - Convert.ToDecimal(nv))) * 100;
        }

        public static bool AnalyzeIAValue(Deck deck, Dealer dealer, int playerCardQtd)
        {
            decimal basePctWinning = 30;

            while (dealer.GetHandValue() < 17)
            {
                decimal aggregateWin = 0;
                var nv = playerCardQtd + dealer.GetCardList().Count;

                for (var i = 21; i >= 17; i--)
                {
                    int cardValueNeed = i - dealer.GetHandValue();

                    var nx = dealer.GetCardList().Count(o => (int)o.cardnum == cardValueNeed);

                    aggregateWin += Core.getValueChance(nx, nv, cardValueNeed);

                    if (aggregateWin > basePctWinning)
                    {
                        dealer.AddCard(deck.HitCard());
                        break;
                    }
                }
            }

            return true;
        }
    }
}
