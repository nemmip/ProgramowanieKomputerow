using System;

namespace PD3
{
    class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStudia[] tab = new[]
            {
                new KandydatNaStudia("Ziębińska", "Julia", 92, 68, 88),
                new KandydatNaStudia("Ziętek", "Amadeusz", 71, 63, 82),
                new KandydatNaStudia("Dmochowski", "Dawid", 96, 33, 84)
            };
            KandydatNaStudia.WyswietlTablice(tab);
        }
    }
}