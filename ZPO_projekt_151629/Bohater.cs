using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_projekt_151629
{
    internal class Bohater:Stwor
    {
        Random random = new Random();
        public static List<Przedmiot> plecak;
        public int pancerz = 0;
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
            obrona = pancerz;
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
            this.obrona = random.Next(1, 6) + pancerz;
        }
        public static void DodajPrzedmiot<T>(T przedmiot, Bohater bohater) where T:Przedmiot
        {
            if(plecak == null)
            {
                plecak = new List<Przedmiot>();
                plecak.Add(przedmiot);
                AktywujPrzedmiot(przedmiot, bohater);
            }
            else
            {
                plecak.Add(przedmiot);
                AktywujPrzedmiot(przedmiot, bohater);
            }
            
        }
        public static void AktywujPrzedmiot<T>(T przedmiot, Bohater bohater) where T:Przedmiot
        {
            switch (przedmiot.typ)
            {
                case "bron":
                    Bron bron = przedmiot as Bron;
                    bohater.max_atak += bron.max_bonus;
                    bohater.min_atak += bron.min_bonus;
                    break;
                case "pancerz":
                    Pancerz pancerz = przedmiot as Pancerz;
                    bohater.obrona += pancerz.bonus;
                    bohater.pancerz = bohater.obrona;
                    break;
                case "mikstura":
                    Mikstura mikstura = przedmiot as Mikstura;
                    for(int i = 0;i<mikstura.cechy.Length;i++)
                    {
                        switch (mikstura.cechy[i])
                        {
                            case "max_atak":
                                bohater.max_atak += mikstura.bonus[i];
                                break;
                            case "min_atak":
                                bohater.min_atak += mikstura.bonus[i];
                                break;
                            case "obrona":
                                bohater.obrona += mikstura.bonus[i];
                                bohater.pancerz = bohater.obrona;
                                break;
                            case "zycie":
                                bohater.zycie += mikstura.bonus[i];
                                break;
                            default:
                                throw new Exception("Brak cechy");
                        }
                    }
                    break;
                default:
                    throw new NotImplementedException("Nie mogę aktywować przedmiotu");
                    
            }
        }
    }
}
