using System;

namespace zad5_7
{
    public interface IFigura:IComparable<IFigura>
    {
        public ConsoleColor Color { get; set; }
        double Pole();
    }
}