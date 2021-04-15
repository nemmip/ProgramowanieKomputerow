using System;

namespace PD5
{
    class MacierzTrojkatna:Macierz
    {
        public MacierzTrojkatna(int[,] macierz)
        {
            if (macierz.GetLength(0) == macierz.GetLength(1))
            {
                _macierz = macierz;
                _typ = GetType().Name;
            }
            else
                throw new ArgumentException("Nieprawidłowy rozmiar tablicy!");
        }

        protected override double Wyznacznik()
        {
            double wyznacznik = 1;
            for (int i = 0; i < _macierz.GetLength(0); i++)
            {
                if (_macierz[i, i] != 0)
                    wyznacznik *= _macierz[i, i];
                else
                    return 0;
            }

            return wyznacznik;
        }
    }
}