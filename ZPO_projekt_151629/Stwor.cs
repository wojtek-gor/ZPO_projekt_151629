using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    public abstract class Stwor
    {
        protected int min_atak;
        protected int max_atak;
        protected int zycie;
        protected int obrona;

        public Stwor(int min_atak, int max_atak, int zycie, int obrona)
        {
            this.min_atak = min_atak;
            this.max_atak = max_atak;
            this.zycie = zycie;
            this.obrona = obrona;
        }

        public abstract int Atak(Stwor stwor);
        public abstract void Obrona();
    }
}
