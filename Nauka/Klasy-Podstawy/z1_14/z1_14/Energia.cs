namespace z1_14
{
    public class Energia
    {
        private readonly double _poczatkowyStanLicznika;
        private double _biezacyStanLicznika;
        
        public double PoczatkowyStan { get=>_poczatkowyStanLicznika; private set{} }
        public double BiezacyStan
        {
            get { return _biezacyStanLicznika; }
            set { _biezacyStanLicznika = value; }
        }

        public Energia(double poczatkowyLicznik, double biezacyLicznik)
        {
            _poczatkowyStanLicznika = poczatkowyLicznik;
            _biezacyStanLicznika = biezacyLicznik;
        }

        public double ZuzytaEnergia() => _biezacyStanLicznika - _poczatkowyStanLicznika;


    }
}