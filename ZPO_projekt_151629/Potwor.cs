using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Potwor:Stwor
    {
        public string nazwa;
        public int obrona_bazowa;
        Random random = new Random();
        /*public Potwor( string nazwa, int min_atak, int max_atak, int zycie, int obrona):base(min_atak, max_atak, zycie, obrona)
        {
            this.nazwa = nazwa;
            obrona_bazowa = obrona;
        }*/
        public Potwor(string nazwa, int min_atak, int max_atak, int zycie, int obrona, int obrona_bazowa) : base(min_atak, max_atak, zycie, obrona)
        {
            this.nazwa = nazwa;
            this.obrona_bazowa = obrona_bazowa;
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
        public void SetObrona()
        {
            obrona = obrona_bazowa;
        }
        public override int Atak(Stwor bohater)
        {
            int obrazenia = random.Next(min_atak, max_atak);
            Bohater wrog = bohater as Bohater;
            if(wrog.GetObrona()<obrazenia)
            {
                wrog.SetZycie(wrog.GetZycie() - (obrazenia - wrog.GetObrona()));
            }
            if (wrog.GetObrona() < obrazenia)
            {
                return obrazenia - wrog.GetObrona();
            }
            return 0;
        }
        public override void Obrona()
        {
            obrona = random.Next(1, 6) + obrona_bazowa;
        }
        public int Decyzja(Bohater bohater)
        {
            if(max_atak - bohater.GetObrona()>=2 || zycie<2)
            {
                return Atak(bohater);
            }
            else
            {
                Obrona();
                return -1;
            }
        }
        public Potwor Kopia()
        {
            return new Potwor(nazwa,min_atak,max_atak,zycie,obrona,obrona_bazowa);
        }
    }
}
