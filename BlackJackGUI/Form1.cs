using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack;

namespace BlackJackGUI
{
    public partial class Form1 : Form
    {
        public Deck gameDeck;

        public Form1()
        {
            InitializeComponent();

            gameDeck = new Deck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image imgDeck = Image.FromFile(Application.StartupPath + @"/CardImages/VersoAzul.png");

            panel1.Width = imgDeck.Width;
            panel1.Height = imgDeck.Height;
            panel1.BackgroundImage = imgDeck;
        }

        private void hitCard()
        {
            Card hittedCard = gameDeck.HitCard();
            int locationX = (71 * gameDeck.listUsedCards().Count) + 5;

            if (hittedCard != null)
            {
                Image imgCard = Image.FromFile(Application.StartupPath + @"/CardImages/" + hittedCard.ToString() + ".png");

                PictureBox pbCardImage = new PictureBox();
                pbCardImage.Image = imgCard;
                pbCardImage.Width = imgCard.Width;
                pbCardImage.Height = imgCard.Height;
                pbCardImage.Location = new Point(locationX, 0);
                pnlHand.Controls.Add(pbCardImage);

                int cardValueSum = Core.AnalyzeHandValue(gameDeck.listUsedCards());

                if (cardValueSum > 21)
                {
                    btnHitCard.Enabled = false;
                }

                lblCardSelected.Text = String.Format("SOMA: {0}", cardValueSum);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hitCard();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            gameDeck = new Deck();
            lblCardSelected.Text = "SOMA: 0";
            btnHitCard.Enabled = true;
            pnlHand.Controls.Clear();
            pnlIA.Controls.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBSelectedCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCardSelected_Click(object sender, EventArgs e)
        {

        }
    }
}
