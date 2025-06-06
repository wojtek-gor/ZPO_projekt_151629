namespace ZPO_projekt_151629
{
    partial class DodajPrzedmiot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_box_nazwa = new System.Windows.Forms.TextBox();
            this.com_box_typ = new System.Windows.Forms.ComboBox();
            this.lbl_min_atak = new System.Windows.Forms.Label();
            this.lbl_max_atak = new System.Windows.Forms.Label();
            this.lbl_zycie = new System.Windows.Forms.Label();
            this.lbl_pancerz = new System.Windows.Forms.Label();
            this.num_min_atak = new System.Windows.Forms.NumericUpDown();
            this.num_max_atak = new System.Windows.Forms.NumericUpDown();
            this.num_zycie = new System.Windows.Forms.NumericUpDown();
            this.num_pancerz = new System.Windows.Forms.NumericUpDown();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.lbl_komunikat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_atak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max_atak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_zycie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pancerz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj przedmiot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Typ:";
            // 
            // text_box_nazwa
            // 
            this.text_box_nazwa.Location = new System.Drawing.Point(97, 79);
            this.text_box_nazwa.Name = "text_box_nazwa";
            this.text_box_nazwa.Size = new System.Drawing.Size(298, 20);
            this.text_box_nazwa.TabIndex = 3;
            // 
            // com_box_typ
            // 
            this.com_box_typ.Items.AddRange(new object[] {
            "Broń",
            "Pancerz",
            "Mikstura"});
            this.com_box_typ.Location = new System.Drawing.Point(97, 109);
            this.com_box_typ.Name = "com_box_typ";
            this.com_box_typ.Size = new System.Drawing.Size(121, 21);
            this.com_box_typ.TabIndex = 4;
            this.com_box_typ.SelectedIndexChanged += new System.EventHandler(this.com_box_typ_SelectedIndexChanged);
            // 
            // lbl_min_atak
            // 
            this.lbl_min_atak.AutoSize = true;
            this.lbl_min_atak.Location = new System.Drawing.Point(35, 155);
            this.lbl_min_atak.Name = "lbl_min_atak";
            this.lbl_min_atak.Size = new System.Drawing.Size(80, 13);
            this.lbl_min_atak.TabIndex = 5;
            this.lbl_min_atak.Text = "Minimalny atak:";
            // 
            // lbl_max_atak
            // 
            this.lbl_max_atak.AutoSize = true;
            this.lbl_max_atak.Location = new System.Drawing.Point(35, 182);
            this.lbl_max_atak.Name = "lbl_max_atak";
            this.lbl_max_atak.Size = new System.Drawing.Size(92, 13);
            this.lbl_max_atak.TabIndex = 6;
            this.lbl_max_atak.Text = "Maksymalny atak:";
            // 
            // lbl_zycie
            // 
            this.lbl_zycie.AutoSize = true;
            this.lbl_zycie.Location = new System.Drawing.Point(35, 209);
            this.lbl_zycie.Name = "lbl_zycie";
            this.lbl_zycie.Size = new System.Drawing.Size(36, 13);
            this.lbl_zycie.TabIndex = 7;
            this.lbl_zycie.Text = "Życie:";
            // 
            // lbl_pancerz
            // 
            this.lbl_pancerz.AutoSize = true;
            this.lbl_pancerz.Location = new System.Drawing.Point(35, 236);
            this.lbl_pancerz.Name = "lbl_pancerz";
            this.lbl_pancerz.Size = new System.Drawing.Size(46, 13);
            this.lbl_pancerz.TabIndex = 8;
            this.lbl_pancerz.Text = "Pancerz";
            this.lbl_pancerz.Click += new System.EventHandler(this.label7_Click);
            // 
            // num_min_atak
            // 
            this.num_min_atak.Location = new System.Drawing.Point(145, 148);
            this.num_min_atak.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_min_atak.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.num_min_atak.Name = "num_min_atak";
            this.num_min_atak.Size = new System.Drawing.Size(120, 20);
            this.num_min_atak.TabIndex = 9;
            // 
            // num_max_atak
            // 
            this.num_max_atak.Location = new System.Drawing.Point(145, 175);
            this.num_max_atak.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_max_atak.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.num_max_atak.Name = "num_max_atak";
            this.num_max_atak.Size = new System.Drawing.Size(120, 20);
            this.num_max_atak.TabIndex = 10;
            // 
            // num_zycie
            // 
            this.num_zycie.Location = new System.Drawing.Point(145, 202);
            this.num_zycie.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_zycie.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.num_zycie.Name = "num_zycie";
            this.num_zycie.Size = new System.Drawing.Size(120, 20);
            this.num_zycie.TabIndex = 11;
            // 
            // num_pancerz
            // 
            this.num_pancerz.Location = new System.Drawing.Point(145, 229);
            this.num_pancerz.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_pancerz.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.num_pancerz.Name = "num_pancerz";
            this.num_pancerz.Size = new System.Drawing.Size(120, 20);
            this.num_pancerz.TabIndex = 12;
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(38, 322);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_dodaj.TabIndex = 13;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(215, 322);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(75, 23);
            this.btn_anuluj.TabIndex = 14;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // lbl_komunikat
            // 
            this.lbl_komunikat.AutoSize = true;
            this.lbl_komunikat.Location = new System.Drawing.Point(399, 175);
            this.lbl_komunikat.Name = "lbl_komunikat";
            this.lbl_komunikat.Size = new System.Drawing.Size(35, 13);
            this.lbl_komunikat.TabIndex = 15;
            this.lbl_komunikat.Text = "label4";
            // 
            // DodajPrzedmiot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_komunikat);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.num_pancerz);
            this.Controls.Add(this.num_zycie);
            this.Controls.Add(this.num_max_atak);
            this.Controls.Add(this.num_min_atak);
            this.Controls.Add(this.lbl_pancerz);
            this.Controls.Add(this.lbl_zycie);
            this.Controls.Add(this.lbl_max_atak);
            this.Controls.Add(this.lbl_min_atak);
            this.Controls.Add(this.com_box_typ);
            this.Controls.Add(this.text_box_nazwa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DodajPrzedmiot";
            this.Text = "DodajPrzedmiot";
            this.Load += new System.EventHandler(this.DodajPrzedmiot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_min_atak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max_atak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_zycie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pancerz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_box_nazwa;
        private System.Windows.Forms.ComboBox com_box_typ;
        private System.Windows.Forms.Label lbl_min_atak;
        private System.Windows.Forms.Label lbl_max_atak;
        private System.Windows.Forms.Label lbl_zycie;
        private System.Windows.Forms.Label lbl_pancerz;
        private System.Windows.Forms.NumericUpDown num_min_atak;
        private System.Windows.Forms.NumericUpDown num_max_atak;
        private System.Windows.Forms.NumericUpDown num_zycie;
        private System.Windows.Forms.NumericUpDown num_pancerz;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label lbl_komunikat;
    }
}