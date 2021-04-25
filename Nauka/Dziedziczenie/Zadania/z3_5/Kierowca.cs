namespace z3_5
{
    public class Kierowca:Pracownik
    {
        private double godziny, stawka;
        private static readonly double premia = 1.15;

        public Kierowca(string imie, string nazwisko, double godziny, double stawka) : base(imie, nazwisko)
        {
            this.godziny = godziny;
            this.stawka = stawka;
        }

        public override string ToString() => base.ToString() + $"{godziny,6} {stawka,6} {Pensja(),8}";
        public override double Pensja() => godziny * stawka * premia;
    }
}