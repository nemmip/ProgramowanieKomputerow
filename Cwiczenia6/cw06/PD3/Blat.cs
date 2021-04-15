using System;
using System.Linq;

namespace PD3
{
    class Blat:Prostokat
    {
        private string _rodzajBlatu;
        private string[] RodzajeBlatow = {"granitowy", "drewniany"};

        public Blat(double dlugosc,double szerokosc, string rodzajBlatu) : base(dlugosc,szerokosc)
        {
            if (RodzajeBlatow.Contains(rodzajBlatu))
                _rodzajBlatu = rodzajBlatu;
            else
                Console.WriteLine("Wprowadzono błędny rodzaj blatu!");
        }

        private double KosztBlatu()
        {
            if (_rodzajBlatu == RodzajeBlatow[0])
                return 600 * Pole();
            else if (_rodzajBlatu == RodzajeBlatow[1])
                return 250 * Pole();
            else
                return -1;
        }

        public override string ToString() => $"Rodzaj blatu: {_rodzajBlatu,10}; Długość: {_dlugosc + "m",5}; " +
                                             $"Szerokość: {_szerokosc + "m",5}; Pole: {Pole() + "m^2",5}; " +
                                             $"Koszt: {KosztBlatu():C}";

    }
}