using System;

namespace PD4
{
    class Program
    {
        static void Main(string[] args)
        {
            Szescian[] tab =
            {
                new Szescian(3),
                new Prostopadloscian(7, 1, 4),
                new Prostopadloscian(3, 8, 7),
                new Prostopadloscian(1, 1, 18),
                new Szescian(6),
                new Szescian(3)
            };
            foreach (Szescian szescian in tab)
                Console.WriteLine(szescian.ToString());
        }
    }
}