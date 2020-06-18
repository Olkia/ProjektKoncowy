using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt53262

{
    public abstract class Prasa
    {
        internal protected string tytul;
        internal protected int nr;
        protected string wydawnictwo;
        protected int tydzWydania;


        public Prasa()
        {
        }
        public Prasa(string tytul, int nr, string wydawnictwo, int tydzWydania)
        {
            this.tytul = tytul;
            this.nr = nr;
            this.wydawnictwo = wydawnictwo;
            this.tydzWydania = tydzWydania;
        }

        public abstract void WypiszInfo();

    }
}
