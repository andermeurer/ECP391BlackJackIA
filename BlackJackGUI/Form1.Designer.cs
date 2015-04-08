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
            this.btnParar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHand = new System.Windows.Forms.Panel();
            this.pnlIA = new System.Windows.Forms.Panel();
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
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(106, 132);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 96);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlHand
            // 
            this.pnlHand.Location = new System.Drawing.Point(25, 174);
            this.pnlHand.Name = "pnlHand";
            this.pnlHand.Size = new System.Drawing.Size(828, 121);
            this.pnlHand.TabIndex = 8;
            // 
            // pnlIA
            // 
            this.pnlIA.Location = new System.Drawing.Point(134, 14);
            this.pnlIA.Name = "pnlIA";
            this.pnlIA.Size = new System.Drawing.Size(601, 112);
            this.pnlIA.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 701);
            this.Controls.Add(this.pnlIA);
            this.Controls.Add(this.pnlHand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnParar);
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
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlHand;
        public System.Windows.Forms.Panel pnlIA;

    }
}

