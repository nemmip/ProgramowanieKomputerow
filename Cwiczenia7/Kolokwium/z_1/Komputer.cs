namespace z_1
{
    public struct Komputer
    {
        #region Pola

        private static uint _id = 0; //unikatowy numer porządkowy
        public RodzajUrzadzenia _rodzaj; // rodzaj urządzenia
        private uint _pojemnoscSSD;//pojemnosc dysku ssd w GB
        private uint _pojemnoscHDD; //pojemnosc dysku hdd w GB
        private double _cena;//cena w zł
        private uint _sumaPojemnosci; // SSD+HDD
        #endregion

        #region Konstruktor
        public Komputer( RodzajUrzadzenia rodzaj, uint pojemnoscSDD, uint pojemnoscHDD, double cena)
        {
            _id++;
            _rodzaj = rodzaj;
            _pojemnoscSSD = pojemnoscSDD;
            _pojemnoscHDD = pojemnoscHDD;
            _cena = cena;
            _sumaPojemnosci = _pojemnoscHDD + _pojemnoscSSD;
        }
        #endregion

        #region Metody

        /// <summary>
        /// Sprawdza czy Komputer po lewej ma mniejszą sumaryczną pow.dyskową od Komputera po prawej
        /// </summary>
        /// <param name="k1">Komputer po lewej</param>
        /// <param name="k2">Komputer po prawej</param>
        /// <returns>Prawda lub fałsz</returns>
        public static bool operator <(Komputer k1, Komputer k2) =>
            k1._sumaPojemnosci < k2._sumaPojemnosci ? true : false;

        /// <summary>
        /// Sprawdza czy Komputer po lewej ma większą sumaryczną pow.dyskową od Komputera po prawej
        /// </summary>
        /// <param name="k1">Komputer po lewej</param>
        /// <param name="k2">Komputer po prawej</param>
        /// <returns>Prawda lub fałsz</returns>
        public static bool operator >(Komputer k1, Komputer k2) =>
            k1._sumaPojemnosci > k2._sumaPojemnosci ? true : false;

        public override string ToString() =>
            $"{_id,4} {_rodzaj,-15} HDD:{_pojemnoscHDD + " GB",5} SSD:{_pojemnoscSSD + " GB",5} {_cena,5:C}";

        #endregion

    }
}