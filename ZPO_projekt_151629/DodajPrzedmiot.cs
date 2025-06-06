using Newtonsoft.Json;
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
    public partial class DodajPrzedmiot : Form
    {
        public DodajPrzedmiot()
        {
            InitializeComponent();
            com_box_typ.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_max_atak.Enabled = false;
            lbl_min_atak.Enabled = false;
            lbl_zycie.Enabled = false;
            lbl_pancerz.Enabled = false;
            num_max_atak.Enabled = false;
            num_min_atak.Enabled = false;
            num_zycie.Enabled = false;
            num_pancerz.Enabled = false;
            lbl_komunikat.Text = "";
        }

        private void DodajPrzedmiot_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void com_box_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(com_box_typ.Text == null)
            {
                lbl_max_atak.Enabled = false;
                lbl_min_atak.Enabled = false;
                lbl_zycie.Enabled = false;
                lbl_pancerz.Enabled = false;
                num_max_atak.Enabled = false;
                num_min_atak .Enabled = false;
                num_zycie.Enabled = false;
                num_pancerz.Enabled = false;
            }
            else if (com_box_typ.Text == "Broń")
            {
                lbl_max_atak.Enabled = true;
                lbl_min_atak.Enabled = true;
                lbl_zycie.Enabled = false;
                lbl_pancerz.Enabled = false;
                num_max_atak.Enabled = true;
                num_min_atak.Enabled = true;
                num_zycie.Enabled = false;
                num_pancerz.Enabled = false;
            }
            else if(com_box_typ.Text == "Pancerz")
            {
                lbl_max_atak.Enabled = false;
                lbl_min_atak.Enabled = false;
                lbl_zycie.Enabled = false;
                lbl_pancerz.Enabled = true;
                num_max_atak.Enabled = false;
                num_min_atak.Enabled = false;
                num_zycie.Enabled = false;
                num_pancerz.Enabled = true;
            }
            else if(com_box_typ.Text == "Mikstura")
            {
                lbl_max_atak.Enabled = true;
                lbl_min_atak.Enabled = true;
                lbl_zycie.Enabled = true;
                lbl_pancerz.Enabled = true;
                num_max_atak.Enabled = true;
                num_min_atak.Enabled = true;
                num_zycie.Enabled = true;
                num_pancerz.Enabled = true;
            }
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_dodaj_Click(object sender, EventArgs e)
        {
            if(text_box_nazwa.Text == "")
            {
                lbl_komunikat.Text = "Przedmiot musi posiadać nazwę";
            }
            else if(com_box_typ.Text == "")
            {
                lbl_komunikat.Text = "Przedmiot musi posiadać typ";
            }
            else
            {
                switch (com_box_typ.Text)
                {
                    case "Broń":
                        Bron nowa_bron = new Bron(text_box_nazwa.Text, "bron", ((int)num_min_atak.Value), ((int)num_max_atak.Value));
                        string bron = File.ReadAllText("bron.json");
                        List<Bron> lista_bron = new List<Bron>();
                        lista_bron = JsonConvert.DeserializeObject<List<Bron>>(bron);
                        lista_bron.Add(nowa_bron);
                        bron = JsonConvert.SerializeObject(lista_bron, Formatting.Indented);
                        File.WriteAllText("bron.json", bron);
                        break;
                    case "Pancerz":
                        Pancerz nowy_pancerz = new Pancerz(text_box_nazwa.Text, "pancerz", ((int)num_pancerz.Value));
                        string pancerz = File.ReadAllText("pancerz.json");
                        List<Pancerz> lista_pancerz = new List<Pancerz>();
                        lista_pancerz = JsonConvert.DeserializeObject<List<Pancerz>>(pancerz);
                        lista_pancerz.Add(nowy_pancerz);
                        pancerz = JsonConvert.SerializeObject(lista_pancerz, Formatting.Indented);
                        File.WriteAllText("pancerz.json", pancerz);
                        break;
                    case "Mikstura":
                        Mikstura nowa_mikstura = new Mikstura(text_box_nazwa.Text, "mikstura", new string[] {"min_atak","max_atak","zycie","obrona"}, new int[] {((int)num_min_atak.Value),((int)num_max_atak.Value),((int)num_zycie.Value),((int)num_pancerz.Value) });
                        string mikstura = File.ReadAllText("mikstury.json");
                        List<Mikstura> lista_mikstura = new List<Mikstura>();
                        lista_mikstura = JsonConvert.DeserializeObject<List<Mikstura>>(mikstura);
                        lista_mikstura.Add(nowa_mikstura);
                        mikstura = JsonConvert.SerializeObject(lista_mikstura, Formatting.Indented);
                        File.WriteAllText("mikstury.json", mikstura);
                        break;
                }
                lbl_komunikat.Text = "Dodano przedmiot";
                await Task.Delay(500);
                this.Close();
            }
        }
    }
}
