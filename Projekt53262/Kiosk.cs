using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt53262
{
    public class Kiosk : KontrolaPrasy
    {
        private string adres;
        public List<Przeglad> listaPrasy = new List<Przeglad>();
        public List<Pracownik> listaPracownikow = new List<Pracownik>();

        public Kiosk()
        {

        }

        public Kiosk(string adres)
        {
            this.adres = adres;
        }


        public void DodajPracownika(Pracownik pracownik)
        {
            if (listaPracownikow == null)
            {
                listaPracownikow[0] = pracownik;
            }
            else
            {
                listaPracownikow.Add(pracownik);
            }
        }

        public void WypiszPracownikow()
        {
            Console.WriteLine("Zatrudnieni w kiosku o adresie: {this.adres}");
            foreach (Pracownik pracownik in listaPracownikow)
            {
                pracownik.WypiszInfo();
            }
        }


        public void DodajPrase(Prasa prasa, string Rodzaj)
        {
            var i = listaPrasy.FindIndex(x => x.Rodzaj == Rodzaj);
            if (i == -1)
            {
                Przeglad przeglad = new Przeglad(Rodzaj);
                DodajPrase(przeglad);
                listaPrasy.Last().DodajPrase(prasa);
            }
            else
            {
                listaPrasy[i].DodajPrase(prasa);
            }
        }

        public void WypiszWszystkiePrasy()
        {
            Console.WriteLine("Wszystkie gazety dostępne w kiosku pod adresem: {this.adres}");
            foreach (Przeglad przeglad in listaPrasy)
            {
                przeglad.WypiszWszystkiePrasy();
            }
        }

        public void ZnajdzPrasePoNr(int i)
        {
            foreach (Przeglad przeglad in listaPrasy)
            {
                przeglad.ZnajdzPrasePoNr(i);
            }
        }

        public void ZnajdzPrasePoTytule(string t)
        {
            foreach (Przeglad przeglad in listaPrasy)
            {
                przeglad.ZnajdzPrasePoTytule(t);
            }
        }
    }
}