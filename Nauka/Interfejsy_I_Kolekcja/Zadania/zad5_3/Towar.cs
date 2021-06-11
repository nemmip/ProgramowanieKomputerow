using System;

namespace zad5_3
{
    public class Towar:IComparable<Towar>
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public double Ilosc { get; set; }

        public override string ToString() => $"{Nazwa,15}{Cena,10:C}{Ilosc,8}";

        public int CompareTo(Towar? other)
        {
            if (other == null) return 1;
            return Cena.CompareTo(other.Cena);
        }
    }
}