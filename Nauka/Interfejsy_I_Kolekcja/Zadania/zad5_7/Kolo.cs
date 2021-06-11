using System;

namespace zad5_7
{
    public class Kolo : IFigura
    {
        public double Promien { get; set; }
        public ConsoleColor Color { get; set; }
        public double Pole() => Math.Round(Math.Pow(Promien, 2) * Math.PI,2);

        public override string ToString() => $"{typeof(Kolo).Name,10} {Pole(),10}";

        public int CompareTo(IFigura? other)
        {
            if (other == null) return 1;
            int wynik = Pole().CompareTo(other.Pole());
            if (wynik==0)
            {
                return Color.CompareTo(other.Color);
            }

            return wynik;
        }
    }
}