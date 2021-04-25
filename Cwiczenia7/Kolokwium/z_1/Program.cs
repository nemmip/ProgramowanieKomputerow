using System;

namespace z_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Komputer[] tab =
            {
                new Komputer(RodzajUrzadzenia.laptop, 250, 500, 2500),
                new Komputer(RodzajUrzadzenia.stacjonarny, 1024, 1024, 1500),
                new Komputer(RodzajUrzadzenia.all_in_one, 150, 0, 1700),
                new Komputer(RodzajUrzadzenia.tablet, 0, 32, 1999),
                new Komputer(RodzajUrzadzenia.laptop,0,1024,3000)
            };
            Console.WriteLine("Podaj rodzaj komputera (Laptop/Stacjonarny/All in one/Tablet");
            RodzajUrzadzenia u = jakiRodzaj(Console.ReadLine());
            foreach (Komputer komputer in tab)
            {
                if (komputer._rodzaj==u)
                Console.WriteLine(komputer.ToString());
            }
            Console.WriteLine(tab[0]<tab[3]);
            Console.WriteLine(tab[1]>tab[2]);

        }
        private static RodzajUrzadzenia jakiRodzaj(string wejscie)
        {
            wejscie = wejscie.ToLower().Replace(' ', '_');//konwersja na odpowiedni typ
            switch (wejscie)
            {
                case "laptop": return RodzajUrzadzenia.laptop;
                case "stacjonarny": return RodzajUrzadzenia.stacjonarny;
                case "all_in_one": return RodzajUrzadzenia.all_in_one;
                case "tablet": return RodzajUrzadzenia.tablet;
                default: throw new ArgumentException("Wprowadzono złe dane!");
            }

        }
    }
}