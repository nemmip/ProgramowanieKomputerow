namespace z3_5
{
    public class Handlowiec:Pracownik
    {
        private double procentProwizji, kwotaTransakcji;

        public Handlowiec(string imie, string nazwisko, double procentProwizji, double kwotaTransakcji) : base(imie,
            nazwisko)
        {
            this.procentProwizji = procentProwizji;
            this.kwotaTransakcji = kwotaTransakcji;
        }

        public override string ToString() => base.ToString() + $"{procentProwizji,6} {kwotaTransakcji,6} {Pensja(),8}";
        public override double Pensja() => procentProwizji * kwotaTransakcji;
        

    }
}