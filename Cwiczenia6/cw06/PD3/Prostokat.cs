namespace PD3
{
    class Prostokat:Figura
    {
        protected double _dlugosc;
        protected double _szerokosc;

        public Prostokat(double dlugosc, double szerokosc)
        {
            _dlugosc = dlugosc;
            _szerokosc = szerokosc;
        }

        protected override double Pole() => _dlugosc * _szerokosc;
        public override string ToString() => $"Długość: {_dlugosc,5}; Szerokość: {_szerokosc,5}; " +
                                             $"Pole: {Pole(),5}; Kolor: {_kolor,5}";
        
    }
}