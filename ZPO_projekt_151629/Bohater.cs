using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Bohater:Stwor
    {
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
        public override void Atak()
        {
            throw new NotImplementedException();
        }
        public override void Obrona()
        {
            throw new NotImplementedException();
        }
    }
}
