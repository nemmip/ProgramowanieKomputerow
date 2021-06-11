using System;
using System.Collections.Generic;

namespace zad5_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoby<IOsoba> osoby = new Osoby<IOsoba>()
            {
                new Pracownik
                {
                    Imie = "Dariusz", KodPocztowy = "42-300", Miasto = "Myszków", Nazwisko = "Tkacz", NumerDomu = "19C",
                    NumerLokalu = 8, Ulica = "Pogodna"
                },
                new Klient
                {
                    Imie = "Zofia", KodPocztowy = "42-200", Miasto = "Częstochowa", Nazwisko = "Nowak",
                    NumerDomu = "21", NumerLokalu = 37, Ulica = "Papieska"
                },
                new Pracownik
                {
                    Imie = "Ewa", KodPocztowy = "41-370", Miasto = "Lipie", Nazwisko = "Nowak", NumerDomu = "7",
                    Ulica = "Fajna"
                },
            };
            Console.WriteLine("Jak posortować osoby?");
            Console.WriteLine("[1] Imie\n"
                              +"[2]Nazwisko\n"
                              +"[3]Miasto\n"
                              +"[4]Ulica\n");
            int.TryParse(Console.ReadLine(), out int wynik);
            osoby.ForEach((x)=>x.Porownanie=wynik);
            osoby.Sort();
            foreach (IOsoba osoba in osoby)
            {
                Osoby<IOsoba>.StworzNaklejke(osoba);
            }
        }
    }
}