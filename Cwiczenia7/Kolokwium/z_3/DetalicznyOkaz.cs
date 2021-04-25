namespace z_3
{
    class DetalicznyOkaz:Klient
    {
        public DetalicznyOkaz(string imie, string nazwisko,uint liczbaSztuk, double cena):base(imie, nazwisko, liczbaSztuk, cena){}
        public override double Rabat() => 0.05*_wartosc;
        

    }
}