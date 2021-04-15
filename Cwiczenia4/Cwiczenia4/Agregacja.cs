/*using System;

namespace Cwiczenia4
{
    // zadanie 4
    public class Agregacja
    {
        private Sprzedaz[] _tablica;
        public Agregacja(Sprzedaz[] tablica)
        {
            _tablica = tablica;
        }

        double Suma()
        {
            var suma = _tablica[0].Wartosc;
            for (int i = 1; i < _tablica.GetLength(0); i++)
            {
                suma += _tablica[i].Wartosc;
            }

            return suma;
        }

        double Srednia()
        {
            return Suma()/_tablica.GetLength(0);
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Suma: {Suma()}, Średnia: {Srednia()}");
        }
    }
}*/