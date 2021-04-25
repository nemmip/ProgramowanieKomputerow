namespace z3_3
{
    class CiastoPizzy:Kolo
    {
        private RodzajCiasta rodzajCiasta;
        static readonly double wspDlaCienkiegoCiasta = 0.0085;
        private static readonly double wspDlaGrubegoCiasta = 0.0095;

        public CiastoPizzy(double promien, RodzajCiasta rodzajCiasta) : base(promien) =>
            this.rodzajCiasta = rodzajCiasta;

        private double KosztProdukcji()
        {
            double wspolczynnik;
            if (rodzajCiasta == RodzajCiasta.CienkieCiasto)
                wspolczynnik = wspDlaCienkiegoCiasta;
            else
                wspolczynnik = wspDlaGrubegoCiasta;
            return Pole() * wspolczynnik;
        }

        public override string ToString() => base.ToString() + $" {KosztProdukcji(),10:C}";
        public override bool Equals(object obj)
        {
            if ((obj == null) || GetType() != obj.GetType())
                return false;
            CiastoPizzy c1 = (CiastoPizzy) obj;
            return base.Equals((Kolo) obj) && rodzajCiasta == c1.rodzajCiasta;
        }
    }
}