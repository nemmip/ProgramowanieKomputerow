using System;

namespace zad3
{
    public class Klient
    {
        // Klasa Klient nie implementuje interfejsu IPremia
        string nazwisko;
        string imie;
        public string Imie { get=>imie; set=>imie=value; }
        public string Nazwisko { get=>nazwisko; set=>nazwisko=value; }
        public Klient(string naz, string im)
        {
            nazwisko = naz;
            imie = im;
        }

    }
}