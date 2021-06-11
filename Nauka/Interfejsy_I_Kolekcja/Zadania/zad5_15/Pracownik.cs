using System;

namespace zad5_15
{
    public class Pracownik:IOsoba
    {
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public int NumerLokalu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Porownanie { get; set; }
        public int CompareTo(IOsoba? other)
        {
            switch (Porownanie)
            {
                case 1: return Imie.CompareTo(other.Imie);
                case 2: return Nazwisko.CompareTo(other.Nazwisko);
                case 3: return Miasto.CompareTo(other.Miasto);
                case 4: return Ulica.CompareTo(other.Ulica);
            }
            throw new ArgumentException("Nieprawidłowe porównanie!");
        }
    }
}