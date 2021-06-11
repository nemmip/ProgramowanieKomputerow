using System;

namespace zad5_7
{
    public class Prostokat:IFigura
    {
        private double a, b;

        public Prostokat(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public ConsoleColor Color { get; set; }
        public double Pole() => a * b;

        public override string ToString() => $"{typeof(Prostokat).Name,10} {Pole(),10}";
        public int CompareTo(IFigura? other)
        {
            if (other == null) return 1;
            int wynik = Pole().CompareTo(other.Pole());
            if (wynik==0)
            {
                return Color.CompareTo(other.Color);
            }

            return wynik;;
        }
    }
}