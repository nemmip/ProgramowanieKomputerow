﻿namespace z_2
{
    class SzafaWnekowa:Szafa
    {
        private double _front;
        private double _sufit;

        public SzafaWnekowa(double wysokosc, double szerokosc, double glebokosc) : base(wysokosc, szerokosc,
            glebokosc)
        {
            _front = _szerokosc * _wysokosc;
            _sufit = _szerokosc * glebokosc;
        }

        public override double Cena() => _front * 100 + _sufit * 20;
        public override string ToString() => base.ToString() + $" {Cena(),6:C}";

    }
}