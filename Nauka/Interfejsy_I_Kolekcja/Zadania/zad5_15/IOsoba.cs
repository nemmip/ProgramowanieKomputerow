using System;

namespace zad5_15
{
    public interface IOsoba:IAdres,IComparable<IOsoba>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Porownanie { get; set; }

    }
}