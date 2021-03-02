using System;

namespace PD1
{
    //Zadanie1
    public class Prostokat
    {
        //Zadanie1
        private double dlugosc;
        private double szerokosc;

        //Zadanie1
        public Prostokat(double Dlugosc, double Szerokosc)
        {
            dlugosc = Dlugosc;
            szerokosc = Szerokosc;
        }

        //Zadanie1
        double Powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        //Zadanie1
        double Obwod()
        {
            return 2 * dlugosc + 2 * szerokosc;
        }

        //Zadanie1
        public override string ToString()
        {
            return $"Długość: {dlugosc}; Szerokość: {szerokosc};{Environment.NewLine}" +
                   $"Powierzchnia: {Powierzchnia()}; Obwód: {Obwod()}";
        }
        //Zadanie 3
        public static double MaxPole(Prostokat[] tablica)
        {
            double maxPole = -1;
            foreach (Prostokat prostokat in tablica)
            {
                if (maxPole<prostokat.Powierzchnia())
                {
                    maxPole = prostokat.Powierzchnia();
                }
            }

            return maxPole;
        }
    }
}