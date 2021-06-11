using System;
using System.Collections.Generic;

namespace zad5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Listy obiektów";
            List<Towar> towary = new List<Towar>
            {
                new Towar {Nazwa = "Długopis", Cena = 4.5, Ilosc = 10},
                new Towar {Nazwa = "Ołówek", Cena = 2.5, Ilosc = 25},
                new Towar {Nazwa = "Blok", Cena = 3, Ilosc = 15}
            };
            int numer = 1;
            foreach (Towar towar in towary)
            {
                Console.WriteLine(
                    $"{numer++,3} {towar.ToString()}");
            }

            List<Osoba> osoby = new List<Osoba>
            {
                new Osoba("Jan", "Kowalski"),
                new Osoba("Ewa", "Nowak")
            };
            foreach (Osoba osoba in osoby)
            {
                Console.WriteLine("Pan/Pani " + osoba.ToString());
            }
        }
    }
}