namespace z_3
{
    class Hurtowy:Klient
    {
        public Hurtowy(string imie, string nazwisko,uint liczbaSztuk, double cena) : base(imie, nazwisko, liczbaSztuk, cena){}
        public override double Rabat()
        {
            if (_liczbaSztuk < 100)
                return _wartosc - 0.05*_wartosc;
            else if (_liczbaSztuk < 200)
                return _wartosc- 0.1*_wartosc;
            else if (_liczbaSztuk < 500)
                return _wartosc - 0.2*_wartosc;
            else
                return _wartosc - 0.3*_wartosc;
        }
        
    }
}