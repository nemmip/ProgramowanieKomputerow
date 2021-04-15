namespace PD5
{
    class MacierzDiagonalna:MacierzTrojkatna
    {
        public MacierzDiagonalna(int[,] macierz) : base(macierz)
        {}

        protected override double Wyznacznik()
        {
            double wyznacznik = 1;
            for (int i = 0; i < _macierz.GetLength(0); i++)
                wyznacznik *= _macierz[i, i];
            return wyznacznik;
        }
    }
}