using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Mikstura:Przedmiot
    {
        public int[] bonus;
        public string[] cechy;
        public Mikstura(string nazwa, string typ, string[] cechy, int[] bonus): base(nazwa, typ)
        {
            this.bonus = bonus;
            this.cechy = cechy;
        }
    }
}
