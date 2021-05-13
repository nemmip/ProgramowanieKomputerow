using System;

namespace zad1
{
    public interface IFigura : IComparable<IFigura>
    {
        public ConsoleColor Kolor { get; set; }
        public double Pole();


    }
}    