using System;

namespace Cwiczenia3
{
    public class Sprzedaz
    {
        #region Pola 
        // na początku definiuje się pola statyczne
        //zadanie2
        public static int liczbaTransakcji; //pole statyczne
        // zadanie1
        private double _cena;
        private int _szt;         
        private bool _upust;
        
        #endregion

        #region Właściwości
        //zadanie1
        public double Wartosc=>_szt * _cena;
                /*{
                    get { return _szt * _cena;}
                    private set { }
                }*/

                public string Upust => _upust ? "udzielono upustu" : "nie udzielono upustu";
                /*{
                    get
                    {
                        if (_upust)
                            return "udzielono upustu";
                        else
                            return "nie udzielono upustu";
                    } 
                    private set {}
                }*/
        #endregion

        #region Konstruktory
        //Zadanie 2
        static Sprzedaz() // konstruktor statyczny
        {
            liczbaTransakcji = 0;
        }
        // zadanie1
        public Sprzedaz(double cena, int szt, bool upust=default)
        {
            _cena = cena;
            _szt = szt;
            _upust = upust;
            liczbaTransakcji++; // zwiększenie pola statycznego

        }
        // zadanie 3 
        // konstruktor kopiujący
        public Sprzedaz(Sprzedaz kopia)
        {
            _cena = kopia._cena;
            _szt = kopia._szt;
            _upust = kopia._upust;
            liczbaTransakcji++;
        }
        #endregion

        #region Metody
        //zadanie1
        public override string ToString()
        {
            //zadanie2
            return $"Wartość sprzedaży: {Wartosc,6:F2}, {Upust} numer transakcji: {liczbaTransakcji}";
            // liczbaTransakcji nie może być wykorzystywana jako pole statyczne do zapamiętania liczby wykonywanych akcji
        }

        public void Wyswietl()
        {
            Console.WriteLine(ToString());
        }
        #endregion
    }
}