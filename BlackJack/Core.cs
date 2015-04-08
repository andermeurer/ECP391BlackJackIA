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


        public static bool AnalyzeIAValue(Dealer dealer, int playerCardQtd)
        {
            // Estratégia padrão de jogador
            // http://www.x121.com/gamblingstrategy/vegas-strip-MG-strategy.gif

            Deck deck = new Deck();
            Dictionary<List<Card>, int> combinacaoesValueDict = new Dictionary<List<Card>, int>();
            Int64 combinacoesPlayer = deck.listCards().Count;

            // Combinação Matemática
            // http://pt.wikipedia.org/wiki/Combina%C3%A7%C3%A3o_%28matem%C3%A1tica%29
            for (int i = deck.listCards().Count - playerCardQtd; i < deck.listCards().Count; i++)
            {
                combinacoesPlayer = combinacoesPlayer * i;
            }

            while (combinacaoesValueDict.Count < combinacoesPlayer)
            {
                deck = new Deck();
                List<Card> newlistCardKey = new List<Card>();

                for (int i = 0; i < playerCardQtd; i++)
                {
                    newlistCardKey.Add(deck.HitCard());
                }

                if (combinacaoesValueDict.Keys.Count > 0)
                {
                    int matchHits = 0;
                    // Loop em todas as chaves ja adicionadas
                    foreach (var listCardKey in combinacaoesValueDict.Keys)
                    {
                        matchHits = 0;
                        // Valida a nova mao se ja foi inclusa na chave do Dicionario
                        foreach (var cardKey in newlistCardKey)
                        {
                            if (listCardKey.Contains(cardKey))
                                matchHits++;

                            if (matchHits == newlistCardKey.Count)
                                break;
                        }

                        if (matchHits == newlistCardKey.Count)
                            break;
                    }

                    if (matchHits != newlistCardKey.Count)
                        combinacaoesValueDict.Add(newlistCardKey, Core.AnalyzeHandValue(newlistCardKey));
                }
                else
                {
                    combinacaoesValueDict.Add(newlistCardKey, Core.AnalyzeHandValue(newlistCardKey));
                }
            }

            int handValueIA = dealer.GetHandValue();

            return true;
        }
    }
}
