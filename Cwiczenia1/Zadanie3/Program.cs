using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sprzedaz[] tablica =
            {
                new Sprzedaz(10, 0.1),
                new Sprzedaz(20, 0.5),
                new Sprzedaz(200, 0.01),
                new Sprzedaz(5,0.09)
            };
            Console.WriteLine(Sprzedaz.MinWart(tablica));
            Console.ReadLine();
        }
    }
}