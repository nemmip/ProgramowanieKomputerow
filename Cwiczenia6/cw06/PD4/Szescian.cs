using System;

namespace PD4
{
    class Szescian
    {
        protected string _nazwa;
        protected double _krawedz;

        public Szescian(double krawedz)
        {
            _krawedz = krawedz;
            _nazwa = GetType().Name;
        }
        public virtual double Objetosc() => Math.Pow(_krawedz, 3);
        public override string ToString() => $"Rodzaj: {_nazwa,16}; a={_krawedz,3}; V={Objetosc()}";

    }
}