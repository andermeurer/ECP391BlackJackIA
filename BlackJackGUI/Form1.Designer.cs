namespace BlackJackGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCardSelected = new System.Windows.Forms.Label();
            this.btnHitCard = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBSelectedCards = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblCardSelected
            // 
            this.lblCardSelected.AutoSize = true;
            this.lblCardSelected.Enabled = false;
            this.lblCardSelected.Location = new System.Drawing.Point(131, 298);
            this.lblCardSelected.Name = "lblCardSelected";
            this.lblCardSelected.Size = new System.Drawing.Size(50, 13);
            this.lblCardSelected.TabIndex = 1;
            this.lblCardSelected.Text = "SOMA: 0";
            this.lblCardSelected.Click += new System.EventHandler(this.lblCardSelected_Click);
            // 
            // btnHitCard
            // 
            this.btnHitCard.Location = new System.Drawing.Point(25, 132);
            this.btnHitCard.Name = "btnHitCard";
            this.btnHitCard.Size = new System.Drawing.Size(75, 23);
            this.btnHitCard.TabIndex = 2;
            this.btnHitCard.Text = "Pegar Carta";
            this.btnHitCard.UseVisualStyleBackColor = true;
            this.btnHitCard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(106, 132);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Novo Jogo";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 96);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBSelectedCards
            // 
            this.listBSelectedCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBSelectedCards.Enabled = false;
            this.listBSelectedCards.FormattingEnabled = true;
            this.listBSelectedCards.Location = new System.Drawing.Point(448, 107);
            this.listBSelectedCards.Name = "listBSelectedCards";
            this.listBSelectedCards.Size = new System.Drawing.Size(179, 182);
            this.listBSelectedCards.TabIndex = 4;
            this.listBSelectedCards.Visible = false;
            this.listBSelectedCards.SelectedIndexChanged += new System.EventHandler(this.listBSelectedCards_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(648, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 96);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBSelectedCards);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnHitCard);
            this.Controls.Add(this.lblCardSelected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardSelected;
        private System.Windows.Forms.Button btnHitCard;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBSelectedCards;
        private System.Windows.Forms.Panel panel2;

    }
}

