namespace gzosoba
{
    public abstract class Pracownik:Osoba
    {
        protected int _lataPracy;
        public Stanowisko _stanowisko;
        private double Urlop => _lataPracy < 10 ? 20 : 26;
        protected virtual double Podstawa() => 3212.25;
        protected abstract double Wynagrodzenie();
    }
}