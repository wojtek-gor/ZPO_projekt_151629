namespace ZPO_projekt_151629
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_graj = new System.Windows.Forms.Button();
            this.btn_dodaj_przeciwnika = new System.Windows.Forms.Button();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.btn_nowy_przedmiot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_graj
            // 
            this.btn_graj.Location = new System.Drawing.Point(276, 92);
            this.btn_graj.Name = "btn_graj";
            this.btn_graj.Size = new System.Drawing.Size(235, 61);
            this.btn_graj.TabIndex = 0;
            this.btn_graj.Text = "Graj";
            this.btn_graj.UseVisualStyleBackColor = true;
            this.btn_graj.Click += new System.EventHandler(this.btn_graj_Click);
            // 
            // btn_dodaj_przeciwnika
            // 
            this.btn_dodaj_przeciwnika.Location = new System.Drawing.Point(276, 160);
            this.btn_dodaj_przeciwnika.Name = "btn_dodaj_przeciwnika";
            this.btn_dodaj_przeciwnika.Size = new System.Drawing.Size(235, 57);
            this.btn_dodaj_przeciwnika.TabIndex = 1;
            this.btn_dodaj_przeciwnika.Text = "Dodaj przeciwnika";
            this.btn_dodaj_przeciwnika.UseVisualStyleBackColor = true;
            this.btn_dodaj_przeciwnika.Click += new System.EventHandler(this.btn_dodaj_przeciwnika_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(276, 287);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(232, 61);
            this.btn_zamknij.TabIndex = 2;
            this.btn_zamknij.Text = "Zamknij";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // btn_nowy_przedmiot
            // 
            this.btn_nowy_przedmiot.Location = new System.Drawing.Point(276, 224);
            this.btn_nowy_przedmiot.Name = "btn_nowy_przedmiot";
            this.btn_nowy_przedmiot.Size = new System.Drawing.Size(232, 57);
            this.btn_nowy_przedmiot.TabIndex = 3;
            this.btn_nowy_przedmiot.Text = "Dodaj przedmiot";
            this.btn_nowy_przedmiot.UseVisualStyleBackColor = true;
            this.btn_nowy_przedmiot.Click += new System.EventHandler(this.btn_nowy_przedmiot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nowy_przedmiot);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.btn_dodaj_przeciwnika);
            this.Controls.Add(this.btn_graj);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Gra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_graj;
        private System.Windows.Forms.Button btn_dodaj_przeciwnika;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.Button btn_nowy_przedmiot;
    }
}

