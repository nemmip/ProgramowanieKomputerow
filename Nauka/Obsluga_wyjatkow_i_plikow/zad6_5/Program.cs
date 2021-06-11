using System;

namespace zad6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Serializacja i deserializacja XML";
            string plik = @"..\..\Towary.xml";
            //test zapisu(serializacji) obiektów do XML
            Towar[] tabTowary = new[]
            {

                new Towar("Długopis", 4.5, 10),
                new Towar("Ołówek", 2.5, 25),
                new Towar("Blok rysunkowy", 3, 15)
            };
            ZbiorTowarow obj = new ZbiorTowarow(tabTowary);
            ZapisOdczytXML.Zapisz(plik,obj);
            
            //test deserializacji
            var kolekcjaTowarow = ZapisOdczytXML.Pobierz<ZbiorTowarow>(plik);
            foreach (var element in kolekcjaTowarow.listaTowarow)
            {
                Console.WriteLine($"{element.Nazwa,15} "+
                                  $"{element.Cena,5} "+
                                  $"{element.Ilosc,5}");
            }
        }
    }
}