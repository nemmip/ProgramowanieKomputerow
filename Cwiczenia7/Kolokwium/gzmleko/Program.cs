using System;

namespace gzmleko
{
    class Program
    {
        static void Main(string[] args)
        {
            Mleko m1 = new Mleko(0.7, 3.2, 2.75);
            Mleko m2 = new Mleko(1, 2, 3.2);
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            Console.WriteLine($"\nKryterium: {Mleko._kryterium} m1 < m2: {m1<m2}");
            Console.WriteLine($"Kryterium: {Mleko._kryterium} m1 > m2: {m1>m2}");
            Mleko.ZmienKryterium(Kryterium.iloscTluszczu);
            Console.WriteLine($"\nKryterium: {Mleko._kryterium} m1 > m2: {m1<m2}");
            Console.WriteLine($"Kryterium: {Mleko._kryterium} m1 > m2: {m1>m2}");
        }
    }
}