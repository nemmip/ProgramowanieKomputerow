namespace zad3
{
    public class DyrektorNaczelny:Dyrektor
    {
        private int _kwotaSpecjalna;
        public string Nazwisko { get=>nazwisko; set=>nazwisko=value; }
        public string Imie { get=>imie; set=>imie=value; }

        public DyrektorNaczelny(int kwotaSpecjalna, string naz, string im, double podstawaPremii) : base(naz, im,
            podstawaPremii)
        {
            _kwotaSpecjalna = kwotaSpecjalna;
        }
        public override double Premia()
        {
            return base.Premia() + _kwotaSpecjalna;
        }
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