namespace z3_10
{
    class WegeDanie:Danie
    {
        private double zawartoscBialka;
        private double zawartoscWeglowodanow;

        public WegeDanie(string nazwaDania, double waga, double kalorycznosc, ushort maksCzasOczekiwania, double cena,
            double zawartoscBialka, double zawartoscWeglowodanow) 
            : base(nazwaDania, waga, kalorycznosc, maksCzasOczekiwania, cena)
        {
            this.zawartoscBialka = zawartoscBialka;
            this.zawartoscWeglowodanow = zawartoscWeglowodanow;
        }

        public override string ToString() => base.ToString() + $" {zawartoscBialka,5}g {zawartoscWeglowodanow,5}g";

    }
}