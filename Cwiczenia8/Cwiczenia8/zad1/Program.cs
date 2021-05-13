using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablica<int> ta = new Tablica<int>(new[] {1, 2, 3, 4});
            Tablica<Osoba> tablica = new Tablica<Osoba>(
                new Osoba[]
                {
                    new Osoba("Jan", "Kowalksi", 34),
                    new Osoba("Anna", "Nowak", 28),

                });

            Console.WriteLine("Enter");
            ta.Wypisz();
            tablica.Wypisz();
            //Console.WriteLine("\nSpacje");


        }
    }
}