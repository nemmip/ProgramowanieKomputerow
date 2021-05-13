namespace PanPani
{
    public class Osoba
    {
        public string _imie, _nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            _imie = imie;
            _nazwisko = nazwisko;
        }

        public override string ToString() => $"{_imie} {_nazwisko}";

    }
}