using System;

namespace z2_13
{
    public struct Kwartalnik
    {
        private string tytul;
        private Kwartal kwartal;
        private int rokWydania;

        public Kwartalnik(string tytul, Kwartal kwartal, int rokWydania)
        {
            this.tytul = tytul;
            this.kwartal = kwartal;
            this.rokWydania = rokWydania;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (Kwartal.WiosnaLato.HasFlag(kwartal))
                Console.ForegroundColor = ConsoleColor.Green;
            return $"{tytul,-20} {kwartal,-3} {rokWydania,-5}";

        }
        
    }
}