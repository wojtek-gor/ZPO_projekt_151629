namespace ZPO_projekt_151629
{
    partial class Nowy_przeciwnik
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
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_nazwa_przeciwnika = new System.Windows.Forms.TextBox();
            this.numBox_min_atak = new System.Windows.Forms.NumericUpDown();
            this.numBox_max_atak = new System.Windows.Forms.NumericUpDown();
            this.numBox_zycie = new System.Windows.Forms.NumericUpDown();
            this.numBox_obrona = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_komunikat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_min_atak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_max_atak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_zycie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_obrona)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_dodaj.Location = new System.Drawing.Point(156, 388);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(134, 29);
            this.btn_dodaj.TabIndex = 0;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_anuluj.Location = new System.Drawing.Point(514, 388);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(141, 28);
            this.btn_anuluj.TabIndex = 1;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa przeciwnika:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimalny atak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maksymalny atak:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zycie przeciwnika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bazowa obrona przeciwnika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(214, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tworzenie nowego przeciwnika";
            // 
            // txtBox_nazwa_przeciwnika
            // 
            this.txtBox_nazwa_przeciwnika.Location = new System.Drawing.Point(230, 81);
            this.txtBox_nazwa_przeciwnika.Name = "txtBox_nazwa_przeciwnika";
            this.txtBox_nazwa_przeciwnika.Size = new System.Drawing.Size(180, 20);
            this.txtBox_nazwa_przeciwnika.TabIndex = 8;
            // 
            // numBox_min_atak
            // 
            this.numBox_min_atak.Location = new System.Drawing.Point(230, 112);
            this.numBox_min_atak.Name = "numBox_min_atak";
            this.numBox_min_atak.Size = new System.Drawing.Size(120, 20);
            this.numBox_min_atak.TabIndex = 9;
            // 
            // numBox_max_atak
            // 
            this.numBox_max_atak.Location = new System.Drawing.Point(230, 142);
            this.numBox_max_atak.Name = "numBox_max_atak";
            this.numBox_max_atak.Size = new System.Drawing.Size(120, 20);
            this.numBox_max_atak.TabIndex = 10;
            // 
            // numBox_zycie
            // 
            this.numBox_zycie.Location = new System.Drawing.Point(230, 172);
            this.numBox_zycie.Name = "numBox_zycie";
            this.numBox_zycie.Size = new System.Drawing.Size(120, 20);
            this.numBox_zycie.TabIndex = 11;
            // 
            // numBox_obrona
            // 
            this.numBox_obrona.Location = new System.Drawing.Point(230, 198);
            this.numBox_obrona.Name = "numBox_obrona";
            this.numBox_obrona.Size = new System.Drawing.Size(120, 20);
            this.numBox_obrona.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // lbl_komunikat
            // 
            this.lbl_komunikat.Location = new System.Drawing.Point(266, 294);
            this.lbl_komunikat.Name = "lbl_komunikat";
            this.lbl_komunikat.Size = new System.Drawing.Size(280, 19);
            this.lbl_komunikat.TabIndex = 13;
            this.lbl_komunikat.Text = "nowy";
            this.lbl_komunikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nowy_przeciwnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_komunikat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numBox_obrona);
            this.Controls.Add(this.numBox_zycie);
            this.Controls.Add(this.numBox_max_atak);
            this.Controls.Add(this.numBox_min_atak);
            this.Controls.Add(this.txtBox_nazwa_przeciwnika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.btn_dodaj);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Nowy_przeciwnik";
            this.Text = "Nowy_przeciwnik";
            ((System.ComponentModel.ISupportInitialize)(this.numBox_min_atak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_max_atak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_zycie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_obrona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_nazwa_przeciwnika;
        private System.Windows.Forms.NumericUpDown numBox_min_atak;
        private System.Windows.Forms.NumericUpDown numBox_max_atak;
        private System.Windows.Forms.NumericUpDown numBox_zycie;
        private System.Windows.Forms.NumericUpDown numBox_obrona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_komunikat;
    }
}