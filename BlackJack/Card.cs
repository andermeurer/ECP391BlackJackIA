using BlackJack.Enumerator;
using BlackJack.Enumerator.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BlackJack
{
    public class Card
    {
        private static CardValueAttr GetAttr(Card card)
        {
            return (CardValueAttr)Attribute.GetCustomAttribute(ForValue(card), typeof(CardValueAttr));
        }

        private static MemberInfo ForValue(Card p)
        {
            return typeof(CardNumType).GetField(Enum.GetName(typeof(CardNumType), p.cardnum));
        }

        public Card(NaipeType naipe, CardNumType cardnum)
        {
            this.naipe = naipe;
            this.cardnum = cardnum;
        }

        public List<int> GetValue()
        {
            List<int> possibleValues = new List<int>();
            try
            {
                CardValueAttr attr = GetAttr(this);
                possibleValues.Add(attr.Value);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            

            return possibleValues;
        }

        public override string ToString()
        {
            return String.Format("{0}{1}", cardnum, naipe);
        }

        public Image GetCardImage()
        {
            return Image.FromFile(Application.StartupPath + @"/CardImages/" + this.ToString() + ".png");
        }

        internal NaipeType naipe { get; set; }
        internal CardNumType cardnum { get; set; }
    }
}
