namespace z_2
{
    class SzafaWolnostojaca:Szafa
    {
        private double _frontPrzodTyl;
        private double _boki;
        private double _podlogaSufit;
        public SzafaWolnostojaca(double wysokosc, double szerokosc, double glebokosc) : base(wysokosc, szerokosc,
            glebokosc)
        {
            _frontPrzodTyl = _wysokosc * _szerokosc;
            _boki = 2 * (_glebokosc * _wysokosc);
            _podlogaSufit = 2 * (_szerokosc * _glebokosc);
        }

        public override double Cena() => 100 * _frontPrzodTyl + 30 * _frontPrzodTyl + 30 * _boki + 40 * _podlogaSufit +
                                         20 * _podlogaSufit;
        

    }
}