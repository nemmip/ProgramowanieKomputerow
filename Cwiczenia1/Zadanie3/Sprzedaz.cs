using System;
using System.Linq;

namespace Zadanie3
{
    class Sprzedaz
    {
        private double cena;
        private double upust;
        private const int szt = 10;

        public Sprzedaz(double price, double vent)
        {
            cena = price;
            upust = vent;
        }

        private double WartPrzed()
        {
            return cena*szt;
        }

        private double WartPo()
        {
            return WartPrzed() - (WartPrzed()*(upust));
        }
        //Wersja B
        public override string ToString()
        {
            string before = $"Wartość przed: cena: {WartPrzed():C};   upust: {upust:P}; sztuki: {szt}";
            string after = $"Wartość po: cena: {WartPo():C};   upust: {upust:P}; sztuki: {szt}";
            return before+ Environment.NewLine+after;
        }
        //Wersja A
        // public override string ToString()
        // {
        //     return $"cena: {cena:C}     upust: {upust:P}    sztuki: {szt}";
        // }
        public static double MinWart(Sprzedaz[] tablica)
        {
            double min=Double.MaxValue;
            
            foreach (Sprzedaz sprzedaz in tablica)
            {
                if (sprzedaz.cena<min)
                {
                    min = sprzedaz.cena;
                }
            }
            return min;
        }

    }
}