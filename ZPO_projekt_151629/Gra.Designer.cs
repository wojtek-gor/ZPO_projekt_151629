namespace ZPO_projekt_151629
{
    partial class Gra
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
            this.btn_atak = new System.Windows.Forms.Button();
            this.btn_obrona = new System.Windows.Forms.Button();
            this.lbl_przeciwnik = new System.Windows.Forms.Label();
            this.lbl_zycie_przeciwnika = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_zycie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_obrona_przeciwnika = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_obrona = new System.Windows.Forms.Label();
            this.lbl_komunikat = new System.Windows.Forms.Label();
            this.lbl_kom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_atak
            // 
            this.btn_atak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_atak.Location = new System.Drawing.Point(229, 386);
            this.btn_atak.Name = "btn_atak";
            this.btn_atak.Size = new System.Drawing.Size(75, 23);
            this.btn_atak.TabIndex = 0;
            this.btn_atak.Text = "Atakuj";
            this.btn_atak.UseVisualStyleBackColor = true;
            this.btn_atak.Click += new System.EventHandler(this.btn_atak_Click);
            // 
            // btn_obrona
            // 
            this.btn_obrona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_obrona.Location = new System.Drawing.Point(503, 386);
            this.btn_obrona.Name = "btn_obrona";
            this.btn_obrona.Size = new System.Drawing.Size(75, 23);
            this.btn_obrona.TabIndex = 1;
            this.btn_obrona.Text = "Broń się";
            this.btn_obrona.UseVisualStyleBackColor = true;
            this.btn_obrona.Click += new System.EventHandler(this.btn_obrona_Click);
            // 
            // lbl_przeciwnik
            // 
            this.lbl_przeciwnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_przeciwnik.Location = new System.Drawing.Point(267, 36);
            this.lbl_przeciwnik.Name = "lbl_przeciwnik";
            this.lbl_przeciwnik.Size = new System.Drawing.Size(280, 29);
            this.lbl_przeciwnik.TabIndex = 2;
            this.lbl_przeciwnik.Text = "Szczur";
            this.lbl_przeciwnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_zycie_przeciwnika
            // 
            this.lbl_zycie_przeciwnika.AutoSize = true;
            this.lbl_zycie_przeciwnika.Location = new System.Drawing.Point(310, 105);
            this.lbl_zycie_przeciwnika.Name = "lbl_zycie_przeciwnika";
            this.lbl_zycie_przeciwnika.Size = new System.Drawing.Size(35, 13);
            this.lbl_zycie_przeciwnika.TabIndex = 3;
            this.lbl_zycie_przeciwnika.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Życie przeciwnika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Życie:";
            // 
            // lbl_zycie
            // 
            this.lbl_zycie.AutoSize = true;
            this.lbl_zycie.Location = new System.Drawing.Point(269, 340);
            this.lbl_zycie.Name = "lbl_zycie";
            this.lbl_zycie.Size = new System.Drawing.Size(35, 13);
            this.lbl_zycie.TabIndex = 6;
            this.lbl_zycie.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Obrona przeciwnika:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_obrona_przeciwnika
            // 
            this.lbl_obrona_przeciwnika.AutoSize = true;
            this.lbl_obrona_przeciwnika.Location = new System.Drawing.Point(568, 105);
            this.lbl_obrona_przeciwnika.Name = "lbl_obrona_przeciwnika";
            this.lbl_obrona_przeciwnika.Size = new System.Drawing.Size(35, 13);
            this.lbl_obrona_przeciwnika.TabIndex = 8;
            this.lbl_obrona_przeciwnika.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Obrona:";
            // 
            // lbl_obrona
            // 
            this.lbl_obrona.AutoSize = true;
            this.lbl_obrona.Location = new System.Drawing.Point(551, 341);
            this.lbl_obrona.Name = "lbl_obrona";
            this.lbl_obrona.Size = new System.Drawing.Size(35, 13);
            this.lbl_obrona.TabIndex = 10;
            this.lbl_obrona.Text = "label6";
            // 
            // lbl_komunikat
            // 
            this.lbl_komunikat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_komunikat.AutoSize = true;
            this.lbl_komunikat.Location = new System.Drawing.Point(383, 214);
            this.lbl_komunikat.Name = "lbl_komunikat";
            this.lbl_komunikat.Size = new System.Drawing.Size(0, 13);
            this.lbl_komunikat.TabIndex = 11;
            // 
            // lbl_kom
            // 
            this.lbl_kom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_kom.Location = new System.Drawing.Point(139, 204);
            this.lbl_kom.Name = "lbl_kom";
            this.lbl_kom.Size = new System.Drawing.Size(511, 23);
            this.lbl_kom.TabIndex = 12;
            this.lbl_kom.Text = "label4";
            this.lbl_kom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_kom);
            this.Controls.Add(this.lbl_komunikat);
            this.Controls.Add(this.lbl_obrona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_obrona_przeciwnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_zycie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_zycie_przeciwnika);
            this.Controls.Add(this.lbl_przeciwnik);
            this.Controls.Add(this.btn_obrona);
            this.Controls.Add(this.btn_atak);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Gra";
            this.Text = "Gra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atak;
        private System.Windows.Forms.Button btn_obrona;
        private System.Windows.Forms.Label lbl_przeciwnik;
        private System.Windows.Forms.Label lbl_zycie_przeciwnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_zycie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_obrona_przeciwnika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_obrona;
        private System.Windows.Forms.Label lbl_komunikat;
        private System.Windows.Forms.Label lbl_kom;
    }
}