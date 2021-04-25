namespace z_3
{
    abstract class Klient
    {
        private string _nazwisko;
        private string _imie;
        protected readonly uint _liczbaSztuk;
        private double _cena;
        protected double _wartosc;

        public string Nazwisko
        {
            get { return _nazwisko; }
            set { _nazwisko = value; }
        }
        public string Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }

        public Klient(string imie, string nazwisko,uint liczbaSztuk, double cena)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _liczbaSztuk = liczbaSztuk;
            _cena = cena;
            _wartosc = _cena * liczbaSztuk;
        }

        public abstract double Rabat();
        public virtual double DoZaplaty() => _wartosc - Rabat();
        public override string ToString() => $"{GetType().Name,-20} {_imie,-10} {_nazwisko,-20} {DoZaplaty(),10:C}";

        public static bool operator <(Klient k1, Klient k2) => k1.DoZaplaty() < k2.DoZaplaty() ? true : false;
        public static bool operator>(Klient k1, Klient k2) => k1.DoZaplaty() > k2.DoZaplaty() ? true : false;
        

    }
}