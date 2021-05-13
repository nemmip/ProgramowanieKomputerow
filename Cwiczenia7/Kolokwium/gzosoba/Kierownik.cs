namespace gzosoba
{
    public class Kierownik:Pracownik
    {
        private double _premia;
        public Kierownik(string imie, string nazwisko, int wiek, int lataPracy, double premia)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _wiek = wiek;
            _lataPracy = lataPracy;
            _stanowisko = Stanowisko.kierownik;
            _premia = premia;
        }

        protected override double Wynagrodzenie() => Podstawa() + _premia;

    }
}