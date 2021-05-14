using System;

namespace zad2
{
    public interface IOsoba:IAdres,IComparable<IOsoba>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Kryterium Kryterium { get; set; }
    }
}