namespace PD1
{
    class Prostokat
    {
        protected double _dlugosc;
        protected double _szerokosc;

        public Prostokat(double dlugosc, double szerokosc)
        {
            _dlugosc = dlugosc;
            _szerokosc=szerokosc;
        }

        protected double Pole() => _dlugosc * _szerokosc;

        public override string ToString() => $"Długość: {_dlugosc + "m",5}; Szerokość: {_szerokosc + "m",5}; " +
                                             $"Pole: {Pole() + "m^2",5}";
    }
}