namespace gzosoba
{
    public abstract class Osoba
    {
        protected string _imie, _nazwisko;
        protected int _wiek;
        public Stanowisko Stanowisko { get; private set; }
        public override string ToString() => $"{_imie} {_nazwisko} {_wiek}lat";

    }
}