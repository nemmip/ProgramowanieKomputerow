using System;

namespace PD1
{
    public class Punkt
    {
        #region Pola

        private double wspolX, wspolY;

        #endregion

        #region Właściwości

        public double WspolX => wspolX;

        public double WspolY => wspolY;

        #endregion
        #region Konstruktor

        public Punkt(double X, double Y)
        {
            wspolX = X;
            wspolY = Y;
        }

        #endregion

        #region Metody

        public void Przesun(double przeX, double przeY)
        {
            wspolX += przeX;
            wspolY += przeY;
        }

        public override string ToString()=>$"X:{wspolX,5} Y:{wspolY,5}";

        public void Wyswietl()
        {
            Console.WriteLine(ToString());
        }

        static public string NaProstej(Punkt[] tablica)
        {
            if (tablica.Length == 3)
            {
                bool wspolliniowosc =
                    (tablica[1].wspolX - tablica[0].wspolX) * (tablica[2].wspolY - tablica[0].wspolY) ==
                    (tablica[1].wspolY - tablica[0].wspolY) * (tablica[2].wspolX - tablica[0].wspolX);
                return wspolliniowosc ? "Punkty są współliniowe" : "Punkty nie są współliniowe";
            }
            else
            return "Za mała lub za duża liczba punktów!";
            
        }

        #endregion
    }
}