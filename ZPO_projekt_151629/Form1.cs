using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPO_projekt_151629
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_graj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gra gra = new Gra();
            gra.Show();
            gra.FormClosed += (s, args) => this.Show();
        }

        private void btn_dodaj_przeciwnika_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nowy_przeciwnik nowy = new Nowy_przeciwnik();
            nowy.Show();
            nowy.FormClosed += (s, args) => this.Show();
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nowy_przedmiot_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajPrzedmiot przedmiot = new DodajPrzedmiot();
            przedmiot.Show();
            przedmiot.FormClosed += (s, args) => this.Show();
        }
    }
}
