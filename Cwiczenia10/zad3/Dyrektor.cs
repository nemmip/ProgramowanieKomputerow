namespace zad3
{
    public class Dyrektor:Pracownik
    {
        public Dyrektor(string naz, string im, double podstawaPremii): base(naz, im,podstawaPremii)  { }
        public override double Premia()
        {
            return base.Premia() * 2;
        }
    }
}