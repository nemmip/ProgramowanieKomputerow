using System;

namespace PD3
{
    public struct KandydatNaStudia
    {
        private string nazwiskoKandydata;
        private string imieKandydata;
        private int punktyMatematyka;
        private int punktyInformatyka;
        private int punktyJezykObcy;

        public KandydatNaStudia(string nazwisko, string imie, int pMatematyka, int pInformatyka, int pJezykObcy)
        {
            nazwiskoKandydata = nazwisko;
            imieKandydata = imie;
            punktyMatematyka = pMatematyka;
            punktyInformatyka = pInformatyka;
            punktyJezykObcy = pJezykObcy;
        }

        private double Punkty() => Math.Round(0.6 * punktyMatematyka + 0.5 * punktyInformatyka + 0.2 * punktyJezykObcy,2);
        public override string ToString() => $"{nazwiskoKandydata,-20}{Punkty(),10}";

        public static void WyswietlTablice(KandydatNaStudia[] tab)
        {
            Console.WriteLine($"{"Nazwisko",-20}{"Punkty",10}");
            foreach (KandydatNaStudia kandydat in tab)
                Console.WriteLine(kandydat.ToString());
        }
    }
}