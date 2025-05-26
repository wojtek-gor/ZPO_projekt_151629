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
    public partial class Gra : Form
    {
        Random random = new Random();
        int ilePotworow = 0;
        List<Potwor> potwory = new List<Potwor>();
        Bohater bohater = new Bohater(1, 6, 6, 0);
        Potwor wrog;
        int runda = 0;
        public Gra()
        {
            InitializeComponent();
            lbl_zycie.Text = bohater.GetZycie().ToString();
            lbl_obrona.Text = bohater.GetObrona().ToString();
            string[] potwor = File.ReadAllLines("Potwory.txt");
            for(int i = 0; i < potwor.Length; i++)
            {
                string[] parametry = potwor[i].Split(';');
                potwory.Add(new Potwor(parametry[0], int.Parse(parametry[1]), int.Parse(parametry[2]), int.Parse(parametry[3]), int.Parse(parametry[4])));
            }
            ilePotworow = potwory.Count;
            Nastepna_runda();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_atak_Click(object sender, EventArgs e)
        {
            bohater.Atak(wrog);
            if(wrog.GetZycie()<1)
            {
                runda = 0;
                Nastepna_runda();
            }
            else
            {
                wrog.Decyzja(bohater);
                if(bohater.GetZycie()<1)
                {
                    this.Close();
                }
                else
                {
                    Nastepna_runda();
                } 
            } 
        }

        private void btn_obrona_Click(object sender, EventArgs e)
        {
            bohater.Obrona();
            wrog.Decyzja(bohater);
            if(bohater.GetZycie()<1)
            {
                this.Close();
            }
            else
            {
                Nastepna_runda();
            }
        }
        private void Nastepna_runda()
        {
            if(runda == 0)
            {
                Nastepna_tura();
            }
            else
            {
                runda++;
                lbl_zycie.Text = bohater.GetZycie().ToString();
                lbl_obrona.Text = bohater.GetObrona().ToString();
                lbl_zycie_przeciwnika.Text = wrog.GetZycie().ToString();
                lbl_obrona_przeciwnika.Text = wrog.GetObrona().ToString();
            }

        }
        private void Nastepna_tura()
        {
            runda++;
            int wybor = random.Next(ilePotworow);
            wrog = potwory[wybor];
            lbl_przeciwnik.Text = wrog.GetNazwa();
            lbl_zycie_przeciwnika.Text = wrog.GetZycie().ToString();
            lbl_obrona_przeciwnika.Text = wrog.GetObrona().ToString();
        }
    }
}
