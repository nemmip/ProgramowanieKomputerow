using System;

namespace PD3
{
    abstract class Figura
    {
        protected ConsoleColor _kolor;
        abstract protected double Pole();
        public override string ToString() => $"Kolor figury: {_kolor}";

    }
}