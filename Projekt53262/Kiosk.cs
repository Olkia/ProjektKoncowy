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
        public List<Przeglad> listaKategorii = new List<Przeglad>();
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
            Console.WriteLine($"\nZatrudnieni w kiosku o adresie:{this.adres}");
            foreach (Pracownik pracownik in listaPracownikow)
            {
                pracownik.WypiszInfo();
            }
        }

        public void DodajKategorie(Przeglad nazwaKategorii)
        {
            if (listaKategorii == null)
            {
                listaKategorii[0] = nazwaKategorii;
            }
            else
            {
                if (listaKategorii.Find(x => x.Rodzaj == nazwaKategorii.Rodzaj) == null)
                {
                    listaKategorii.Add(nazwaKategorii);
                }
            }
        }

        public void DodajPrase(Prasa prasa, string Rodzaj)
        {
            var i = listaKategorii.FindIndex(x => x.Rodzaj == Rodzaj);
            if (i == -1)
            {
                Przeglad przeglad = new Przeglad(Rodzaj);
                DodajKategorie(przeglad);
                listaKategorii.Last().DodajPrase(prasa);
            }
            else
            {
                listaKategorii[i].DodajPrase(prasa);
            }
        }

        public void WypiszWszystkiePrasy()
        {
            Console.WriteLine($"\nWszystkie gazety dostępne w kiosku pod adresem: {this.adres}");
            foreach (Przeglad przeglad in listaKategorii)
            {
                przeglad.WypiszWszystkiePrasy();
            }
        }

        public void ZnajdzPrasePoNr(int i)
        {
            foreach (Przeglad przeglad in listaKategorii)
            {
                przeglad.ZnajdzPrasePoNr(i);
            }
        }

        public void ZnajdzPrasePoTytule(string tytul)
        {
            foreach (Przeglad przeglad in listaKategorii)
            {
                przeglad.ZnajdzPrasePoTytule(tytul);
            }
        }
    }
}