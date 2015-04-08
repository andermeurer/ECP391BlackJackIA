using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack;

namespace BlackJackGUI
{
    public static class GameBoard
    {

        public static void PlayerHand(List<Card> cardList)
        {
            var form = (Form1)Form.ActiveForm;

            form.pnlHand.Controls.Clear();

            foreach (var card in cardList)
            {
                int locationX = (71 * cardList.IndexOf(card)) + 5;
                Image imgCard = card.GetCardImage();

                PictureBox pbCardImage = new PictureBox();
                pbCardImage.Image = imgCard;
                pbCardImage.Width = imgCard.Width;
                pbCardImage.Height = imgCard.Height;
                pbCardImage.Location = new Point(locationX, 0);

                form.pnlHand.Controls.Add(pbCardImage);
            }            
        }

        public static void DealerHand(List<Card> cardList)
        {
            var form = (Form1)Form.ActiveForm;

            form.pnlIA.Controls.Clear();

            int locationX = 10;

            foreach (var card in cardList)
            {
                Image imgCardIA = card.GetCardImage();

                PictureBox pbCardImageIA = new PictureBox();
                pbCardImageIA.Image = imgCardIA;
                pbCardImageIA.Width = imgCardIA.Width;
                pbCardImageIA.Height = imgCardIA.Height;
                pbCardImageIA.Location = new Point(locationX, 0);

                form.pnlIA.Controls.Add(pbCardImageIA);
            }
        }
    }
}
