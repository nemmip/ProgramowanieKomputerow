using System;
using System.Collections.Generic;

namespace zad5_2_2
{
    class Program
    {
        private static void WypisanieListy(IWypisz obiekt, string opis)
        {
            Console.WriteLine(opis+" "+DateTime.Now.ToString());
            obiekt.Wypisz();
        }
        static void Main(string[] args)
        {
            Console.Title = "Listy obiektów";
            Towary<Towar> towary = new Towary<Towar>
            {
                new Towar {Nazwa = "Długopis", Cena = 4.5, Ilosc = 10},
                new Towar {Nazwa = "Ołówek", Cena = 2.5, Ilosc = 25},
                new Towar {Nazwa = "Blok", Cena = 3, Ilosc = 15}
            };

            Osoby<Osoba> osoby = new Osoby<Osoba>
            {
                new Osoba("Jan", "Kowalski"),
                new Osoba("Ewa", "Nowak")
            };

            WypisanieListy(towary,"Stan magazynu");
            Console.WriteLine();
            WypisanieListy(osoby,"Wykaz osób");
        }
    }
}