using System;

namespace Cwiczenia3
{
    static class Dodatki
    {
        public static double NettoNaBrutto(double cena, double podatekVat)
        {
            double VAT = Math.Round(cena * podatekVat / 100, 2);
            return cena + VAT;
        }

        public static double BruttoNaNetto(double cena, double podatekVat)
        {
            double VAT = Math.Round(cena * podatekVat / (podatekVat + 100), 2);
            return cena - VAT;
        }
    }
}