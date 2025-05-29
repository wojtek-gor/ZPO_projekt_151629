using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPO_projekt_151629
{
    public partial class Nowy_przeciwnik : Form
    {
        public Nowy_przeciwnik()
        {
            InitializeComponent();
            lbl_komunikat.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_dodaj_Click(object sender, EventArgs e)
        {
            string przeciwnik = "";
            if(txtBox_nazwa_przeciwnika.Text == "")
            {
                lbl_komunikat.Text = "Nadaj nazwę przeciwnikowi";
            }
            else if(numBox_max_atak.Value <= numBox_min_atak.Value)
            {
                lbl_komunikat.Text = "Maksymalny atak musi być większy od minimalnego";
            }
            else if(numBox_max_atak.Value == 0)
            {
                lbl_komunikat.Text = "Maksymalny atak nie może być zerem";
            }
            else if(numBox_zycie.Value == 0)
            {
                lbl_komunikat.Text = "Życie nie może być zerem";
            }
            else
            {
                przeciwnik = "\n"+txtBox_nazwa_przeciwnika.Text + ";" + numBox_min_atak.Value.ToString() + ";" + numBox_max_atak.Value.ToString() + ";" + numBox_zycie.Value.ToString() + ";" + numBox_obrona.Value.ToString();
                File.AppendAllText("Potwory.txt", przeciwnik);
                lbl_komunikat.Text = "Przeciwnik dodany";
                await Task.Delay(1000);
                this.Close();
            }
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
