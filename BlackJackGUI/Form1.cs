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

            if (hittedCard != null)
            {
                #region Carta virada Dealer
                if (pnlIA.Controls.Count == 0)
                {
                    Card hittedCardIA = gameDeck.HitCard();
                    dealer.AddCard(hittedCardIA);

                    GameBoard.DealerHand(this, dealer.GetCardList());
                }
                #endregion

                player.AddCard(hittedCard);
                GameBoard.PlayerHand(player.GetCardList());

                int cardValueSum = Core.AnalyzeHandValue(player.GetCardList());

                //lblCardSelected.Text = String.Format("SOMA: {0}", cardValueSum);
                GameBoard.PlayerHand(player.GetCardList());

                if (cardValueSum > 21)
                {

                    if (dealer.Play(gameDeck, player, dealer))
                    {
                        GameBoard.DealerHand(this, dealer.GetCardList());

                        btnHitCard.Enabled = false;
                        MessageBox.Show("Fim de jogo. Você perdeu!");
                        this.NewGame();
                    }
                    else
                    {
                        GameBoard.DealerHand(this, dealer.GetCardList());

                        if (player.GetHandValue() < dealer.GetHandValue())
                        {
                            btnHitCard.Enabled = false;
                            MessageBox.Show("Fim de jogo. Você venceu!");
                            this.NewGame();
                        }

                        else if (player.GetHandValue() == dealer.GetHandValue())
                        {
                            btnHitCard.Enabled = false;
                            MessageBox.Show("Fim de jogo. Ninguem venceu!");
                            this.NewGame();
                        }

                        else
                        {
                            btnHitCard.Enabled = false;
                            MessageBox.Show("Fim de jogo. Você perdeu!");
                            this.NewGame();
                        }
                    }
                }
                else if (cardValueSum == 21)
                {
                    if (dealer.Play(gameDeck, player, dealer))
                    {
                        GameBoard.DealerHand(this, dealer.GetCardList());

                        btnHitCard.Enabled = false;
                        MessageBox.Show("Fim de jogo. Ninguem venceu!");
                        this.NewGame();
                    }
                    else
                    {
                        GameBoard.DealerHand(this, dealer.GetCardList());

                        btnHitCard.Enabled = false;
                        MessageBox.Show("Fim de jogo.Você ganhou!");
                        this.NewGame();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hitCard();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (dealer.Play(gameDeck, player, dealer))
            {
                GameBoard.DealerHand(this, dealer.GetCardList());

                btnHitCard.Enabled = false;
                MessageBox.Show("Fim de jogo. Você perdeu!");
                this.NewGame();
            }
            else
            {
                GameBoard.DealerHand(this, dealer.GetCardList());

                btnHitCard.Enabled = false;
                MessageBox.Show("Fim de jogo. Você venceu!");
                this.NewGame();
            }                        
        }

        private void NewGame()
        {
            gameDeck = new Deck();
            player = new Player();
            dealer = new Dealer();
            
            btnHitCard.Enabled = true;
            GameBoard.PlayerHand(player.GetCardList());
            GameBoard.DealerHand(this, dealer.GetCardList());
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
