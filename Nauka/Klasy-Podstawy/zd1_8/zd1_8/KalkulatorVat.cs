using System;

namespace zd1_8
{
    static class KalkulatorVat
    {
        private static int[] stawki = {0, 5, 8, 23};

        public static double NettoNaBrutto(double netto, int stawkaVat, out double kwotaVat)
        {
            if (Array.IndexOf(stawki, stawkaVat) < 0)//sprawdza poprawnosc wprowadzonej stawki vat
                throw new ArgumentException("Nieprawidłowa stawka VAT"); //jeśli nie występuje to zwraca -1
            kwotaVat = Math.Round(netto * stawkaVat / 100, 2);
            return netto + kwotaVat;
        }

        public static double BruttoNaNetto(double brutto, int stawkaVat, out double kwotaVat)
        {
            if (Array.IndexOf(stawki, stawkaVat) < 0)
                throw new ArgumentException("Nieprawidłowa stawka VAT");
            kwotaVat = Math.Round(brutto * stawkaVat / (stawkaVat + 100), 2);
            return brutto - kwotaVat;
        }
        
    }
}