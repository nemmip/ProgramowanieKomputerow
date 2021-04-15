using System;

namespace PD1
{
    public struct Ulamki
    {
        //pola
        private int licznik;
        private int mianownik;
        //konstruktor
        public Ulamki(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }
        //metody
        private static int NWD(Ulamki ulamek)
        {
            //a=mianownik b= licznik
            int dzielnik = default;
            int reszta = default;
            int a = ulamek.mianownik, b = ulamek.licznik;
            while (dzielnik==0)
            {
                if (a%b==0)
                    dzielnik = b;
                else
                {
                    reszta = a % b;
                    a = b;
                    b = reszta;
                }
            }
            return dzielnik;
        }
        private static Ulamki Skracanie(Ulamki ulamek)
        {
            //znaleźć NWD
            int dzielnik = NWD(ulamek);
            ulamek.licznik /= dzielnik;
            ulamek.mianownik /= dzielnik;
            return ulamek;
        }
        public override string ToString() => $"{licznik}/{mianownik}";
        //operatory
        public static Ulamki operator +(Ulamki lewy, Ulamki prawy)
        {
            Ulamki ulamki = new Ulamki();
            //sprowadzenie do wspolnego mianownika
            //wersja gdy mianowniki sa rowne
            if (lewy.mianownik == prawy.mianownik)
            {
                ulamki.licznik = lewy.licznik + prawy.licznik;
                ulamki.mianownik = lewy.mianownik;
            }
            else
            {
                //sprowadzamy do wspólnego mianownika
                ulamki.licznik = lewy.licznik * prawy.mianownik + prawy.licznik * lewy.mianownik;
                ulamki.mianownik = lewy.mianownik * prawy.mianownik;
            }
            //skracamy otrzymany ulamek
            return Skracanie(ulamki);

        }

        public static Ulamki operator -(Ulamki lewy, Ulamki prawy)
        {
            Ulamki ulamki = new Ulamki();
            //sprowadzenie do wspolnego mianownika
            //wersja gdy mianowniki sa rowne
            if (lewy.mianownik == prawy.mianownik)
            {
                ulamki.licznik = lewy.licznik - prawy.licznik;
                ulamki.mianownik = lewy.mianownik;
            }
            else
            {
                //sprowadzamy do wspólnego mianownika
                ulamki.licznik = lewy.licznik * prawy.mianownik - prawy.licznik * lewy.mianownik;
                ulamki.mianownik = lewy.mianownik * prawy.mianownik;
            }
            //skracamy otrzymany ulamek
            return Skracanie(ulamki);
        }

        public static Ulamki operator *(Ulamki lewy, Ulamki prawy)
        {
            Ulamki ulamki = new Ulamki();
            ulamki.licznik = lewy.licznik * prawy.licznik;
            ulamki.mianownik = lewy.mianownik * prawy.mianownik;
            return Skracanie(ulamki);
        }

        //liczba z prawej
        public static Ulamki operator *(Ulamki ulamek, int liczba)
        {
            Ulamki ulamki = new Ulamki();
            ulamki.licznik = ulamek.licznik * liczba;
            ulamki.mianownik = ulamek.mianownik;
            return Skracanie(ulamki);
        }
        //liczba z lewej
        public static Ulamki operator *(int liczba, Ulamki ulamek)
        {
            Ulamki ulamki = new Ulamki();
            ulamki.licznik = ulamek.licznik * liczba;
            ulamki.mianownik = ulamek.mianownik;
            return Skracanie(ulamki);
        }
    }
}