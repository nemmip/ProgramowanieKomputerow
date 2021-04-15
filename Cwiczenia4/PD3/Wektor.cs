using System;

namespace PD3
{
    public class Wektor
    {
        private int[] _wektor;

        public Wektor(int[] wektor)
        {
            _wektor = wektor;
        }

        public Wektor(Wektor kopia)
        {
            _wektor = kopia._wektor;
        }

        public void Wyswietl()
        {
            foreach (int i in _wektor)
                Console.Write($"{i,5}");
            Console.WriteLine();
        }

        static public int IloczynSkalarny(Wektor w1, Wektor w2)
        {
            if (w1._wektor.Length == w2._wektor.Length)
            {
                int iloczyn = default;
                for (int i = 0; i < w1._wektor.Length; i++)
                    iloczyn += w1._wektor[i] * w2._wektor[i];
                    
                return iloczyn;
            }
            else
            {
                Console.WriteLine("Wektory nie są sobie równe!");
                return int.MinValue;
            }
        }
        
    }
}