using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPO_projekt_151629
{
    public partial class Gra : Form
    {
        Random random = new Random();
        int ilePotworow = 0;
        List<Potwor> potwory = new List<Potwor>();
        List<Bron> bron = new List<Bron>();
        List<Pancerz> pancerz = new List<Pancerz>();
        List<Mikstura> mikstura = new List<Mikstura>();
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
            string potwor = File.ReadAllText("potwory.json");
            potwory = JsonConvert.DeserializeObject<List<Potwor>>(potwor);
            ilePotworow = potwory.Count;
            string bronie = File.ReadAllText("bron.json");
            bron = JsonConvert.DeserializeObject<List<Bron>>(bronie);
            string panc = File.ReadAllText("pancerz.json");
            pancerz = JsonConvert.DeserializeObject<List<Pancerz>>(panc);
            string miks = File.ReadAllText("mikstury.json");
            mikstura = JsonConvert.DeserializeObject<List<Mikstura>>(miks);
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
                lbl_kom.Text = "";
                LosujPrzedmiot();
                Aktualizuj_napisy();
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
        private async void LosujPrzedmiot()
        {
            if(random.Next(0,10001)%2 == 0)
            {
                int wybor = random.Next(0, 1001)%3;
                switch (wybor)
                {
                    case 0:
                        var wybrana_bron = bron[random.Next(bron.Count)];
                        var odp_b = MessageBox.Show("Znalazłeś przedmiot " + wybrana_bron.nazwa + " !!!\nCzy chcesz go zatrzymać?", "Przyjęcie przedmiotu", MessageBoxButtons.YesNo);
                        if(odp_b == DialogResult.Yes)
                        {
                            Bohater.DodajPrzedmiot<Bron>(wybrana_bron, bohater);
                            lbl_kom.Text = "Przedmiot dodany";
                            await Task.Delay(700);
                            lbl_kom.Text = "";
                        }
                        else
                        {
                            lbl_kom.Text = "Przedmiot odrzucony";
                            await Task.Delay(700);
                            lbl_kom.Text = "";
                        }
                        break;
                    case 1:
                        var wybrana_pancerz = pancerz[random.Next(pancerz.Count)];
                        var odp_p = MessageBox.Show("Znalazłeś przedmiot " + wybrana_pancerz.nazwa + " !!!\nCzy chcesz go zatrzymać?", "Przyjęcie przedmiotu", MessageBoxButtons.YesNo);
                        if (odp_p == DialogResult.Yes)
                        {
                            Bohater.DodajPrzedmiot<Pancerz>(wybrana_pancerz, bohater);
                            lbl_kom.Text = "Przedmiot dodany";
                            await Task.Delay(700);
                            lbl_kom.Text = "";
                        }
                        else
                        {
                            lbl_kom.Text = "Przedmiot odrzucony";
                            await Task.Delay(700);
                            lbl_kom.Text = "";
                        }
                        break;
                    case 2:
                        var wybrana_mikstura = mikstura[random.Next(mikstura.Count)];
                        var odp = MessageBox.Show("Znalazłeś przedmiot " + wybrana_mikstura.nazwa + " !!!\nCzy chcesz go zatrzymać?", "Przyjęcie przedmiotu", MessageBoxButtons.YesNo);
                        if (odp == DialogResult.Yes)
                        {
                            Bohater.DodajPrzedmiot<Mikstura>(wybrana_mikstura, bohater);
                            lbl_kom.Text = "Przedmiot dodany";
                            await Task.Delay(700);
                            lbl_kom.Text = "";
                        }
                        else
                        {
                            lbl_kom.Text = "Przedmiot odrzucony";
                            await Task.Delay(700);
                            lbl_kom.Text = "";
                        }
                        break;
                    default:
                        throw new Exception("Niwłaściwy przedmiot");
                }
            } 
        }
    }
}
