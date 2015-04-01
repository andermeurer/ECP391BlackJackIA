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

        private void ListHitCards()
        {
            listBSelectedCards.Items.Clear();

            foreach (Card card in gameDeck.listUsedCards())
            {
                listBSelectedCards.Items.Add(card.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListHitCards();

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

                Panel newCardPanel = new Panel();
                newCardPanel.Width = imgCard.Width;
                newCardPanel.Height = imgCard.Height;
                newCardPanel.BackgroundImage = imgCard;
                newCardPanel.Location = new Point(locationX, 175);
                this.Controls.Add(newCardPanel);

                int cardValueSum = Core.AnalyzeHandValue(gameDeck.listUsedCards());

                if (cardValueSum > 21)
                {
                    btnHitCard.Enabled = false;
                }

                lblCardSelected.Text = String.Format("SOMA: {0}", cardValueSum);
                ListHitCards();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hitCard();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            panel2.Invalidate();
            gameDeck = new Deck();
            lblCardSelected.Text = "SOMA: 0";
            btnHitCard.Enabled = true;

            ListHitCards();
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
