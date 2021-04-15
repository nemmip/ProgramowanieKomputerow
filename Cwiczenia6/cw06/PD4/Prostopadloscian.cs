namespace PD4
{
    class Prostopadloscian:Szescian
    {
        //_krawedz niech bedzie szerokoscia podstawy
        private double _dlugoscPodstawy;
        private double _wysokosc;

        public Prostopadloscian(double wysokosc, double szerokoscPodstawy, double dlugoscPodstawy):base(krawedz:szerokoscPodstawy)
        {
            _wysokosc = wysokosc;
            _dlugoscPodstawy = dlugoscPodstawy;
        }

        public override double Objetosc() => _wysokosc * _dlugoscPodstawy * _krawedz;

        public override string ToString() =>
            $"Rodzaj: {_nazwa}; a={_krawedz,3}; b={_dlugoscPodstawy,3}; c={_wysokosc,3}; " +
            $"V={Objetosc(),5}";

    }
}