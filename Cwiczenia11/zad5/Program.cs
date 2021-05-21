using System;
using System.Collections.Generic;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            string plik = @"..\..\Towary.xml";
            Rachunek rachunek = new Rachunek
            {
                DataZakupu = DateTime.Now,
                NumerRachunku = "101/2019",
                PozycjaRachunku = new List<Towar>()
                {
                    new Towar{Cena = 4.5,Ilosc = 10,NazwaTowaru = "Długopis"},
                    new Towar{Cena = 2.5,Ilosc = 25,NazwaTowaru = "Ołówek"},
                    new Towar{Cena = 3,Ilosc = 15,NazwaTowaru = "Blok rysunkowy"}
                }
            };
            ZapisOdczytXML.Zapisz(plik,rachunek);
            var kolekcjaTowarow =
                ZapisOdczytXML.Pobierz<Rachunek>(plik);
            foreach (var towar in kolekcjaTowarow.PozycjaRachunku)
            {
                Console.WriteLine($"{towar.NazwaTowaru,15}" +
                                  $"{towar.Cena,5}" +
                                  $"{towar.Ilosc,5}");
            }
        }
    }
}