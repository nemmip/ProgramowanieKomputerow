using System;

namespace z_3
{
    class DetalicznyStaly:Klient
    {
        private double _lataWspolpracy;

        public DetalicznyStaly(string imie, string nazwisko,uint liczbaSztuk, double cena, double lataWspolpracy) : base(imie, nazwisko, liczbaSztuk, cena) =>
            _lataWspolpracy = lataWspolpracy;

        public override double Rabat() => _wartosc * Math.Round(_lataWspolpracy) / 100;
    }
}