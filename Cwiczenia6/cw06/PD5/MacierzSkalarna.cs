using System;

namespace PD5
{
    sealed class MacierzSkalarna:MacierzDiagonalna
    {
        public MacierzSkalarna(int[,]macierz):base(macierz){}
        protected override double Wyznacznik() => Math.Pow(_macierz[0, 0], _macierz.GetLength(0));

    }
}