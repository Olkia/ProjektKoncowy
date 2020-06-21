using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt53262
{
    class Gazeta : Prasa
    {
        public Gazeta()
        {
        }

        public Gazeta(string tytul, int nr, string wydawnictwo, int tydzWydania) : base(tytul, nr, wydawnictwo, tydzWydania)
        {
            this.tytul = tytul;
            this.nr = nr;
            this.wydawnictwo = wydawnictwo;
            this.tydzWydania = tydzWydania;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine($"\nGazeta");
            Console.WriteLine($"\nTytuł: {this.tytul}");
            Console.WriteLine($"\nNr: { this.nr}");
            Console.WriteLine($"\nWydawnictwo: {this.wydawnictwo}");
            Console.WriteLine($"\nTydzien wydania: {this.tydzWydania}");
        }
    }
}
