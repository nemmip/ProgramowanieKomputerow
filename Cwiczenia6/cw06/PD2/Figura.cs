using System;

namespace PD2
{
    abstract class Figura
    {
        protected ConsoleColor _kolor;
        abstract protected double Pole();
        public override string ToString() => $"Kolor figury: {_kolor}";

    }
}