namespace zad6
{
    public class Towar
    {
        private string _symbol;
        private string _nazwa;
        private double _cena;

        public string Symbol => _symbol;

        public string Nazwa => _nazwa;

        public double Cena => _cena;

        public Towar(string symbol, string nazwa, double cena)
        {
            _symbol = symbol;
            _nazwa = nazwa;
            _cena = cena;
        }
    }
}