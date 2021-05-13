using System;

namespace zad4
{
    public enum KrytSamochod
    {
        rokProdukcji,
        przebieg,
        pojemnosc
    }
    public class Car
    {
        private string _marka;
        private string _model;
        private int _rokProdukcji;
        private int _przebieg;
        private double _pojemnosc;
        private static KrytSamochod _kryterium = KrytSamochod.przebieg;

        /// <summary>
        /// Pozwala zmienić kryterium porównywania
        /// </summary>
        public static KrytSamochod Kryterium
        {
            get => _kryterium;
            set => _kryterium = value;
        }

        public Car(string marka, string model, int rokProdukcji, int przebieg, double pojemnosc)
        {
            _marka = marka;
            _model = model;
            _rokProdukcji = rokProdukcji;
            _przebieg = przebieg;
            _pojemnosc = pojemnosc;
        }

        public static bool Porownaj(Car c1, Car c2) => c1 > c2 ? true : false;
        public static bool operator <(Car c1, Car c2)
        {
            switch (_kryterium)
            {
                case KrytSamochod.pojemnosc: return c1._pojemnosc < c2._pojemnosc ? true : false;
                case KrytSamochod.przebieg: return c1._przebieg < c2._przebieg ? true : false;
                case KrytSamochod.rokProdukcji: return c1._rokProdukcji < c2._rokProdukcji ? true : false;
                default: throw new Exception();
            }
        }
        public static bool operator >(Car c1, Car c2)
        {
            switch (_kryterium)
            {
                case KrytSamochod.pojemnosc: return c1._pojemnosc > c2._pojemnosc ? true : false;
                case KrytSamochod.przebieg: return c1._przebieg > c2._przebieg ? true : false;
                case KrytSamochod.rokProdukcji: return c1._rokProdukcji > c2._rokProdukcji ? true : false;
                default: throw new Exception();
            }
        }

        public override string ToString() => $"{_marka,-15}{_model,10}{_rokProdukcji,5}{_pojemnosc,5}{_przebieg,10}";

    }
}