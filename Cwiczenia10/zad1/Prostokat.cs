using System;

namespace zad1
{
    public class Prostokat:IFigura
    {
        private double _a, _b;
        private ConsoleColor _kolor;
        public ConsoleColor Kolor { get=>_kolor; set=>_kolor=value; }
        public Prostokat(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public virtual double Pole() =>Math.Round(_a * _b,2) ;
        public override string ToString() => $"Dł {_a,15}; Szer {_b,5}; Pole: {Pole(),10};";
        public int CompareTo(IFigura obj) => obj == null ? 1 : Pole().CompareTo(obj.Pole());



    }
}