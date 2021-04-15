using System;

namespace Cwiczenia3
{
    // zadanie 4
    public class Agregacja
    {
        private Sprzedaz s1, s2, s3;
        public Agregacja(Sprzedaz s1,Sprzedaz s2,Sprzedaz s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        double Suma()
        {
            return s1.Wartosc+s2.Wartosc+s3.Wartosc;
        }

        double Srednia()
        {
            //nie wolno odwoływać się do pola statycznego innej klasy!
            //return Suma()/Sprzedaz.liczbaTransakcji;// to nie jest dobry pomysł, ponieważ liczba transakcji jest zwiększana o 1 cały czas i może zliczać poprzednio utworzone obiekty
            return Suma() / 3;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Suma: {Suma()}, Średnia: {Srednia()}");
        }
    }
}