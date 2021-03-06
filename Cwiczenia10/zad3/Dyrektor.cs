﻿using System;

namespace zad3
{
    public class Dyrektor:Pracownik
    {
        public string Nazwisko { get=>nazwisko; set=>nazwisko=value; }
        public string Imie { get=>imie; set=>imie=value; }
        public Dyrektor(string naz, string im, double podstawaPremii): base(naz, im,podstawaPremii)  { }
        public override double Premia()
        {
            return base.Premia() * 2;
        }
        public int CompareTo(IPremia? other)
        {
            if (other == null) return 1;
            int wynik = Nazwisko.CompareTo(other.Nazwisko);
            if (wynik==0)
                wynik = Imie.CompareTo(other.Imie);
            return wynik;
        }
    }
}