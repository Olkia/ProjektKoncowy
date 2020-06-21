using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt53262
{
    class Program
    {
        static void Main(string[] args)
        {
            Przeglad dziecieca = new Przeglad("Dla dzieci");
            Przeglad codzienna = new Przeglad("Dziennik");
            Przeglad tygodniowa = new Przeglad("Tygodnik");

            Gazeta g1 = new Gazeta("Przedszkolak", 0, "Edipresse", 5);
            Gazeta g2 = new Gazeta("Mycraft", 1, "Bauer", 10);
            Gazeta g3 = new Gazeta("Hobby Extra", 2, "BPV", 44);
            Gazeta g4 = new Gazeta("Dziennik Gazeta Prawna", 3, "‎Infor Biznes", 12);
            Gazeta g5 = new Gazeta("Fakt", 4, "Ringier Axel Springer", 9);
            Gazeta g6 = new Gazeta("Gazeta Wyborcza", 5, "Agora", 50);
            Gazeta g7 = new Gazeta("Tele Tydzień", 6, "Bauer", 33);
            Gazeta g8 = new Gazeta("Życie na gorąco", 7, "Bauer", 1);
            Gazeta g9 = new Gazeta("Polityka", 8, "Polityka", 28);

            Kiosk kiosk1 = new Kiosk("ul. Dąbrowszczaków, 80-364 Gdańsk");
            Kiosk kiosk2 = new Kiosk("ul. Stanisławy Nadstawek, 63-830 Pępowo");

            Pracownik p1 = new Pracownik("Jan", "Kret", "2010-11-12", 2500);
            Pracownik p2 = new Pracownik("Maryla", "Koral", "2018-01-01", 2300);
            Pracownik p3 = new Pracownik("Sara", "Dolan", "2015-10-26", 2000);

            kiosk1.DodajPracownika(p1);
            kiosk2.DodajPracownika(p2);
            kiosk1.DodajPracownika(p3);

            kiosk1.WypiszWszystkiePrasy();
            Console.WriteLine("\n\n");

            kiosk1.DodajPrase(g1, "Dziennik");
            kiosk1.DodajPrase(g2, "Tygodnik");
            kiosk1.DodajPrase(g3, "Dla dzieci");

            kiosk1.WypiszWszystkiePrasy();
            Console.WriteLine("\n\n");

            kiosk1.WypiszPracownikow();
            Console.WriteLine("\n\n");

            kiosk1.ZnajdzPrasePoNr(0);
            kiosk1.ZnajdzPrasePoNr(10);
            kiosk1.ZnajdzPrasePoNr(110);

            Console.WriteLine("\n\n");

            kiosk1.ZnajdzPrasePoTytule("Polityka");
            Console.WriteLine("\n\n");

            kiosk2.WypiszPracownikow();
            Console.WriteLine("\n\n");

            kiosk2.DodajPrase(g1, "Tygodnik");

            kiosk2.ZnajdzPrasePoNr(0);
            kiosk2.ZnajdzPrasePoNr(10);
            kiosk2.ZnajdzPrasePoNr(110);

            Console.WriteLine("\n\n");

            kiosk2.WypiszWszystkiePrasy();
            Console.WriteLine("\n\n");

            kiosk2.ZnajdzPrasePoTytule("Fakt");
            Console.WriteLine("\n\n");
            Console.ReadLine();

        }
    }
}
