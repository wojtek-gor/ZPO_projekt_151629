using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Potwor:Stwor
    {
        private string nazwa;
        private int obrona_bazowa;
        Random random = new Random();
        public Potwor( string nazwa, int min_atak, int max_atak, int zycie, int obrona):base(min_atak, max_atak, zycie, obrona)
        {
            this.nazwa = nazwa;
            obrona_bazowa = obrona;
        }
        public string GetNazwa()
        {
            return nazwa;
        }
        public int GetZycie()
        {
            return zycie;
        }
        public int GetObrona()
        {
            return obrona;
        }
        public int GetMinAtak()
        {
            return min_atak;
        }
        public int GetMaxAtak()
        {
            return max_atak;
        }
        public int GetObronaBazowa()
        {
            return obrona_bazowa;
        }
        public void SetZycie(int zycie)
        {
            this.zycie = zycie;
        }
        public override void Atak(Stwor bohater)
        {
            int obrazenia = random.Next(min_atak, max_atak);
            Bohater wrog = bohater as Bohater;
            wrog.SetZycie(wrog.GetZycie()-(obrazenia-wrog.GetObrona()));
        }
        public override void Obrona()
        {
            obrona = random.Next(1, 6) + obrona_bazowa;
        }
        public void Decyzja(Bohater bohater)
        {
            if(max_atak - bohater.GetObrona()>=2 || zycie<2)
            {
                Atak(bohater);
            }
            else
            {
                Obrona();
            }
        }
    }
}
