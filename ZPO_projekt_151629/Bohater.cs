using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Bohater:Stwor
    {
        Random random = new Random();
        public Bohater(int min_atak, int max_atak, int zycie, int obrona) : base(min_atak, max_atak, zycie, obrona)
        {

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
        public void SetZycie(int zycie)
        {
            this.zycie = zycie;
        }
        public void SetObrona()
        {
            obrona = 0;
        }
        public override int Atak(Stwor potwor)
        {
            int obrazenia = random.Next(min_atak, max_atak);
            Potwor wrog = potwor as Potwor;
            if(wrog.GetObrona()<obrazenia)
            {
                wrog.SetZycie(wrog.GetZycie() - (obrazenia - wrog.GetObrona()));
            }
            wrog.SetObrona();
            if(wrog.GetObrona() < obrazenia)
            {
                return obrazenia - wrog.GetObrona();
            }
            return 0;
        }
        public override void Obrona()
        {
            this.obrona = random.Next(1, 6);
        }
    }
}
