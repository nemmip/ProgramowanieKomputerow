namespace z3_10
{
    class Danie
    {
        private string nazwaDania;
        private double waga;
        private double kalorycznosc;
        private ushort maksCzasOczekiwania;
        private double cena;

        public Danie(string nazwaDania, double waga, double kalorycznosc, ushort maksCzasOczekiwania, double cena)
        {
            this.nazwaDania = nazwaDania;
            this.waga = waga;
            this.kalorycznosc = kalorycznosc;
            this.maksCzasOczekiwania = maksCzasOczekiwania;
            this.cena = cena;
        }

        private double Kalorie() => (kalorycznosc * 100.0) / waga;

        public override string ToString() => $"{nazwaDania,-20} {waga,9:F2}g {Kalorie(),9:F2}kcal/100g " +
                                             $"{maksCzasOczekiwania,5}min {cena,9:C}";

    }
}