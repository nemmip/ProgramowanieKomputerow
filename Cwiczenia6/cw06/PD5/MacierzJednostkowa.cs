using System;

namespace PD5
{
    class MacierzJednostkowa:Macierz
    {
        public MacierzJednostkowa(int[,] macierz)
        {
            if (macierz.GetLength(0) == macierz.GetLength(1))
            {
                _macierz = macierz;
                _typ = GetType().Name;
            }
            else
                throw new ArgumentException("Nieprawidłowy rozmiar tablicy!");
        }

        protected override double Wyznacznik() => _macierz.GetLength(0);
        
        
    }
}