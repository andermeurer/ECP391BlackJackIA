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

            form.lblPlayerPts.Text = String.Format("Pontos Jogador: {0}", Core.AnalyzeHandValue(cardList));
        }

        public static void DealerHand(Form1 form, List<Card> cardList)
        {
            form.pnlIA.Controls.Clear();

            foreach (var card in cardList)
            {
                int locationX = (71 * cardList.IndexOf(card)) + 10;
                Image imgCardIA = card.GetCardImage();

                PictureBox pbCardImageIA = new PictureBox();
                pbCardImageIA.Image = imgCardIA;
                pbCardImageIA.Width = imgCardIA.Width;
                pbCardImageIA.Height = imgCardIA.Height;
                pbCardImageIA.Location = new Point(locationX, 0);

                form.pnlIA.Controls.Add(pbCardImageIA);
            }

            form.lblDealerPts.Text = String.Format("Pontos Dealer: {0}", Core.AnalyzeHandValue(cardList));
        }
    }
}
