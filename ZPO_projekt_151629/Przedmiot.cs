using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    public abstract class Przedmiot
    {
        public string nazwa;
        public string typ;
        public Przedmiot(string nazwa, string typ)
        {
            this.nazwa = nazwa;
            this.typ = typ;
        }
    }
}
