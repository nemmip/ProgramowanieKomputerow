namespace z3_5
{
    public abstract class Pracownik
    {
        private string imie, nazwisko;

        public Pracownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString() => $"{imie,-10} {nazwisko,-15} {GetType().Name,-10}";
        public abstract double Pensja();

    }
}