using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Pancerz:Przedmiot
    {
        public int bonus;
        public Pancerz(string nazwa, string typ,  int bonus): base(nazwa, typ)
        {
            this.bonus = bonus;
        }
    }
}
