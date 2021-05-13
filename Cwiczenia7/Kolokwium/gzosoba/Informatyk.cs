namespace gzosoba
{
    public class Informatyk:Pracownik
    {
        public Informatyk(string imie, string nazwisko, int wiek, int lataPracy)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _wiek = wiek;
            _lataPracy = lataPracy;
            _stanowisko = Stanowisko.informatyk;
        }

        protected override double Wynagrodzenie() =>
            _wiek <= 26 ? (Podstawa() * _wiek / 100) * 1.17 : Podstawa() * _wiek / 100;
       
    }
}