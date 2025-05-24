using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    public abstract class Stwor
    {
        private int min_atak;
        private int max_atak;
        private int zycie;

        public abstract void Atak();
        public abstract void Obrona();
        public abstract void Decyzja();
    }
}
