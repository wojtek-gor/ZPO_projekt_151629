using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Bron:Przedmiot
    {
        public int min_bonus;
        public int max_bonus;
        public Bron(string nazwa, string typ, int min_bonus, int max_bonus) : base(nazwa, typ) 
        { 
            this.min_bonus = min_bonus;
            this.max_bonus = max_bonus;
        }
    }
}
