namespace zad1
{
    public class Osoba
    {
        private string _imie;

        public string Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }

        private string _nazwisko;

        public string Nazwisko
        {
            get { return _nazwisko; }
            set { _nazwisko = value; }
        }

        private int _wiek;

        public int Wiek
        {
            get { return _wiek; }
            set { _wiek = value; }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _wiek = wiek;
        }

        public override string ToString() => $"{_imie,-15} {_nazwisko,-15} {_wiek,-5}";

    }
}