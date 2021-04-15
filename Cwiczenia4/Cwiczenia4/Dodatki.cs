using System;

namespace Cwiczenia4
{
    static class Dodatki
    {
        // ref - argument wejscia/wyjścia
        /*public static double NettoNaBrutto( double cena, int stawkaVat, ref double kwotaVat)
        {
            kwotaVat= Math.Round(cena * stawkaVat / 100, 2);
            return cena+ kwotaVat;
        }*/
        // out - argument wyjścia
        /*public static double NettoNaBrutto(double cena, int stawkaVat, out double kwotaVat)
        {
            kwotaVat = Math.Round(cena * stawkaVat / 100, 2);
            return cena + kwotaVat;
        }
        */
        
        // out i ref
        public static double NettoNaBrutto(double cena, int stawkaVat, out double kwotaVat, ref double sumaVat)
        {
            kwotaVat = Math.Round(cena * stawkaVat / 100, 2);
            sumaVat += kwotaVat;
            return cena + kwotaVat;
        }

        public static double BruttoNaNetto(double cena,int stawkaVat, out double kwotaVat)
        {
            kwotaVat = Math.Round(cena * stawkaVat / (stawkaVat + 100), 2);
            return cena - kwotaVat;
        }
       public static double Suma(Sprzedaz [] _tablica)
        {
            var suma = _tablica[0].Wartosc;
            for (int i = 1; i < _tablica.GetLength(0); i++)
            {
                suma += _tablica[i].Wartosc;
            }

            return suma;
        }

        public static double Srednia(Sprzedaz [] _tablica)
        {
            return Suma(_tablica)/_tablica.GetLength(0);
        }
    }
}