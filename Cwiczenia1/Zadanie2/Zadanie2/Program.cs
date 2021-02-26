using System;

namespace Zadanie2
{
    class Program
    {
        static void Main()
        {
            Sprzedaz[] tablica =
            {
                new Sprzedaz(10, 0.1),
                new Sprzedaz(20, 0.5),
                new Sprzedaz(200, 0.01)
            };
            foreach (Sprzedaz si in tablica)
            {
                Console.WriteLine(si.ToString());
            }

            Console.ReadLine();
        }
    }
}