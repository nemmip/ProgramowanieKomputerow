﻿namespace zad5
{
    public class Klient:Osoba
    {
        public Klient(string imie, string nazwisko, string kodPocztowy, string miasto, string ulica, int numerDomu,
            int numerMieszkania=0)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _kodPocztowy = kodPocztowy;
            _miasto = miasto;
            _ulica = ulica;
            _numerDomu = numerDomu;
            _numerMieszkania = numerMieszkania;
        }
    }
}