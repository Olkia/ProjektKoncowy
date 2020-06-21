using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt53262
{
    public class Przeglad : KontrolaPrasy
    {
        public List<Prasa> listaPrasy = new List<Prasa>();
        private object tytul;

        public string Rodzaj { get; private set; }
        public Przeglad()
        {
        }

        public Przeglad(string Rodzaj)
        {
            this.Rodzaj = Rodzaj;
        }
        public void DodajPrase(Prasa prasa)
        {
            if (listaPrasy == null)
            {
                listaPrasy[0] = prasa;
            }
            else
            {
                listaPrasy.Add(prasa);
            }

        }

        public void WypiszWszystkiePrasy()
        {
            Console.WriteLine($"\nKategoria : {this.Rodzaj}");
            foreach (Prasa prasa in listaPrasy)
            {
                prasa.WypiszInfo();
            }
        }

        public void ZnajdzPrasePoNr(int i)
        {
            var tmp = listaPrasy.Find(x => x.nr == i);
            if (tmp != null)
            {
                Console.WriteLine($"\nZnaleziono prasę o nr {i} w katalogu: {this.Rodzaj}");
                tmp.WypiszInfo();
            }
        }

        public void ZnajdzPrasePoTytule(string tytul)
        {
            var tmp = listaPrasy.Find(x => x.tytul == tytul);
            if (tmp != null)
            {
                Console.WriteLine($"\nZnaleziono pozycję o tytule {this.tytul} w katalogu: {this.listaPrasy}");
                tmp.WypiszInfo();
            }
        }
    }
}
