namespace zad3
{
    public class Pracownik:IPremia
    {
        string nazwisko;
        string imie;
        private readonly double _podstawaPremii;
        public double podstawaPremii { get=>_podstawaPremii; set{} }


        public Pracownik(string naz, string im,double podstawaPremii)
        {
            nazwisko = naz;
            imie = im;
            _podstawaPremii = podstawaPremii;
        }
        public virtual double Premia() => podstawaPremii * 0.1;
    }
}