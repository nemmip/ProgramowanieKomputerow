using System;

namespace zad3
{
    public class Pracownik:IPremia
    {
        protected string nazwisko;
        protected string imie;
        private readonly double _podstawaPremii;
        public double podstawaPremii { get=>_podstawaPremii; set{} }
        public string Nazwisko { get=>nazwisko; set=>nazwisko=value; }
        public string Imie { get=>imie; set=>imie=value; }

        public Pracownik(string naz, string im,double podstawaPremii)
        {
            nazwisko = naz;
            imie = im;
            _podstawaPremii = podstawaPremii;
        }
        public virtual double Premia() => podstawaPremii * 0.1;
        public int CompareTo(IPremia? other)
        {
            if (other == null) return 1;
            int wynik = Nazwisko.CompareTo(other.Nazwisko);
            if (wynik==0)
                wynik = Imie.CompareTo(other.Imie);
            return wynik;
        }
    }
}