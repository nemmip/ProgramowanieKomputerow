using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Towar[] tab = new[]
            {
                new Towar("DL-2111-M1", "Długopis", 3.5),
                new Towar("OL-2137-M1", "Ołówek", 2.5)
            };
            foreach (Towar towar in tab)
            {
                TablicaObiektow<Towar>.Opis(towar);
            }
        }
    }
}