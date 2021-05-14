using System;

namespace zad3
{
    public interface IPremia:IComparable<IPremia>
    {
        public double podstawaPremii { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        double Premia();
    }
}