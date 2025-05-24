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
            this.SuspendLayout();
            // 
            // btn_graj
            // 
            this.btn_graj.Location = new System.Drawing.Point(280, 125);
            this.btn_graj.Name = "btn_graj";
            this.btn_graj.Size = new System.Drawing.Size(235, 61);
            this.btn_graj.TabIndex = 0;
            this.btn_graj.Text = "Graj";
            this.btn_graj.UseVisualStyleBackColor = true;
            this.btn_graj.Click += new System.EventHandler(this.btn_graj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_graj);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Gra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_graj;
    }
}

