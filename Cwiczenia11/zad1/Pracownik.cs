using System;

namespace zad1
{
    public class Pracownik
    {
        private string _imie, _nazwisko;
        private int _godziny, _stawka;
        public string Imie { get=>_imie; set=>_imie=value; }
        public string Nazwisko { get=>_nazwisko; set=>_nazwisko=value; }
        public int Godziny { get=>_godziny; set=>_godziny=value; }
        public int Stawka { get=>_stawka; set=>_stawka=value; }

        public Pracownik(string imie, string nazwisko, int godziny, int stawka)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _godziny = godziny;
            _stawka = stawka;
        }

        public Pracownik(string[] tablicaDanych)
        {
            if (tablicaDanych.Length == 4)
            {
                _imie = tablicaDanych[0];
                _nazwisko = tablicaDanych[1];
                _godziny = int.Parse(tablicaDanych[2]);
                _stawka = int.Parse(tablicaDanych[3]);
            }
            else
                throw new ArgumentException("Nieprawidłowa wielkość tablicy!");
        }

        public double Pensja() => _godziny * _stawka;
        public override string ToString() => $"{_imie,-15}{_nazwisko,-15}{_godziny,10}{_stawka,10}{Pensja(),10}";
    }
}