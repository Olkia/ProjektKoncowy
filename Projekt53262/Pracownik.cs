using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt53262
{
    public class Pracownik : Osoba
    {
        private string dataZatrudnienia;
        private double wyplata;


        public Pracownik()
        {

        }

        public Pracownik(string imie, string nazwisko, string dataZatrudnienia, double wyplata) : base(imie, nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataZatrudnienia = dataZatrudnienia;
            this.wyplata = wyplata;
        }


        public void WypiszInfo()
        {
            Console.WriteLine("Pracownik");
            Console.WriteLine("Imię: {this.imie}");
            Console.WriteLine("Nazwisko: {this.nazwisko}");
            Console.WriteLine("Data zatrudnienia: {this.dataZatrudnienia}");
            Console.WriteLine("Wynagrodzenie: {this.wyplata}");
        }
    }
}
