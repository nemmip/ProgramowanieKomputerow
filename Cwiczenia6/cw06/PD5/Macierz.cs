namespace PD5
{
    abstract class Macierz
    {
        protected string _typ;
        protected int[,] _macierz; 
        abstract protected double Wyznacznik();
        public override string ToString() => $"{_typ,-20} Wyznacznik: {Wyznacznik(),5}";

    }
}