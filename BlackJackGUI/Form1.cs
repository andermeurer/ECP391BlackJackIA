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
        public Deck gameDeck { get; set; }
        public Player player { get; set; }
        public Dealer dealer { get; set; }

        public Form1()
        {
            InitializeComponent();

            gameDeck = new Deck();
            player = new Player();
            dealer = new Dealer();
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
            int locationX = (71 * player.GetCardList().Count) + 5;

            if (hittedCard != null)
            {
                #region Carta virada Dealer
                if (pnlIA.Controls.Count == 0)
                {
                    Card hittedCardIA = gameDeck.HitCard();

                    dealer.AddCard(hittedCardIA);

                    Image imgCardIA = hittedCardIA.GetCardImage();

                    PictureBox pbCardImageIA = new PictureBox();
                    pbCardImageIA.Image = imgCardIA;
                    pbCardImageIA.Width = imgCardIA.Width;
                    pbCardImageIA.Height = imgCardIA.Height;
                    pbCardImageIA.Location = new Point(10, 0);

                    pnlIA.Controls.Add(pbCardImageIA);
                }
                #endregion

                player.AddCard(hittedCard);

                Image imgCard = hittedCard.GetCardImage();

                PictureBox pbCardImage = new PictureBox();
                pbCardImage.Image = imgCard;
                pbCardImage.Width = imgCard.Width;
                pbCardImage.Height = imgCard.Height;
                pbCardImage.Location = new Point(locationX, 0);

                pnlHand.Controls.Add(pbCardImage);

                int cardValueSum = Core.AnalyzeHandValue(player.GetCardList());

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
            player = new Player();
            dealer = new Dealer();

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
