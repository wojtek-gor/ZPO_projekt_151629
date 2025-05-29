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
        int tura = 0;
        public Gra()
        {
            InitializeComponent();
            
            lbl_kom.Text = "";
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

        private async void btn_atak_Click(object sender, EventArgs e)
        {
            btn_atak.Enabled = false;
            btn_obrona.Enabled = false;
            lbl_kom.Text = "Bohater zadał "+bohater.Atak(wrog).ToString()+" obrażeń";
            Aktualizuj_napisy();
            await Task.Delay(1000);
            if(wrog.GetZycie()<1)
            {
                runda = 0;
                Nastepna_runda();
            }
            else
            {
                int dec = wrog.Decyzja(bohater);
                if(dec < 0)
                {
                    lbl_kom.Text = "Przeciwnik się broni";
                }
                else
                {
                    lbl_kom.Text = "Bohater otrzymał " + dec.ToString() + " obrażeń";
                }
                if(bohater.GetZycie()<1)
                {
                    lbl_kom.Text = "Niestety przegrałeś";
                    await Task.Delay(1000);
                    this.Close();
                }
                else
                {
                    await Task.Delay(1000);
                    lbl_kom.Text = "";
                    Nastepna_runda();
                } 
            }
            btn_atak.Enabled = true;
            btn_obrona.Enabled = true;
        }

        private async void btn_obrona_Click(object sender, EventArgs e)
        {
            btn_atak.Enabled = false;
            btn_obrona.Enabled = false;
            bohater.Obrona();
            lbl_kom.Text = "Bochater broni się";
            Aktualizuj_napisy();
            await Task.Delay(1000);
            int dec = wrog.Decyzja(bohater);
            if (dec < 0)
            {
                lbl_kom.Text = "Przeciwnik się broni";
            }
            else
            {
                lbl_kom.Text = "Bohater otrzymał " + dec.ToString() + " obrażeń";
            }
            if (bohater.GetZycie()<1)
            {
                lbl_kom.Text = "Niestety przegrałeś";
                await Task.Delay(1000);
                this.Close();
            }
            else
            {
                await Task.Delay(1000);
                lbl_kom.Text = "";
                Nastepna_runda();
            }
            btn_atak.Enabled = true;
            btn_obrona.Enabled = true;
        }
        private void Aktualizuj_napisy()
        {
            lbl_zycie.Text = bohater.GetZycie().ToString();
            lbl_obrona.Text = bohater.GetObrona().ToString();
            lbl_zycie_przeciwnika.Text = wrog.GetZycie().ToString();
            lbl_obrona_przeciwnika.Text = wrog.GetObrona().ToString();
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
                bohater.SetObrona();
                Aktualizuj_napisy();
            }

        }
        private void Nastepna_tura()
        {
            runda++;
            tura++;
            int wybor = random.Next(ilePotworow);
            wrog = potwory[wybor].Kopia();
            lbl_licznik_tury.Text = tura.ToString();
            lbl_przeciwnik.Text = wrog.GetNazwa();
            lbl_zycie_przeciwnika.Text = wrog.GetZycie().ToString();
            lbl_obrona_przeciwnika.Text = wrog.GetObrona().ToString();

        }
    }
}
