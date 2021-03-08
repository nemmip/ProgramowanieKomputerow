using System;

namespace Wartosci_Domyslne
{
    class Program
    {
        static void Main(string[] args)
        {
            // string imie = "Jan";
            // double waga = 70;
            //Console.WriteLine($"Imie: {imie}, Waga: {waga}kg");

            // konstruktor domyślny przypisywane są wartości domyślne dla danego typu
            Osoba os1 = new Osoba();
            Console.WriteLine($"Imie: {os1.imie}, Waga:{os1.waga}");
            Console.ReadLine();
        }
    }

    class Osoba
    {
        public string imie;
        public double waga;
    }
}
