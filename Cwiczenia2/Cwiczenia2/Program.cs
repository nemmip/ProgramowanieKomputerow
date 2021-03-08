using System;

namespace Cwiczenia2
{
    class Osoba
    {
        public string imie, nazwisko;

        public Osoba(string Imie="Jan", string Nazwisko="Kowalski")
        {
            imie = Imie;
            nazwisko = Nazwisko;
        }

        public override string ToString()
        {
            return $"{imie} {nazwisko}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os1 = new Osoba();
            Osoba os2 = new Osoba("Ewa", "Karo");
            
            // tylko jeśli pola są dostępne publicznie
            // Osoba os3 = new Osoba();
            // os3.imie = "Iga";
            // os3.nazwisko = "Karo";

            Osoba os4 = new Osoba
            {
                imie = "Iza",
                nazwisko = "Trefl"
            };
            
            //Console.WriteLine(os1.ToString());
            //Console.WriteLine(os2.ToString());
            Console.WriteLine(os4.ToString());
            Console.ReadLine();
        }
    }
}