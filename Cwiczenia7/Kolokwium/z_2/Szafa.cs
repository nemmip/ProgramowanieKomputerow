using System;

namespace z_2
{
    abstract class Szafa
    {
        #region Pola

        protected double _wysokosc, _szerokosc, _glebokosc;

        #endregion

        #region Konstruktor

        public Szafa(double wysokosc, double szerokosc, double glebokosc)
        {
            _wysokosc = wysokosc>0?wysokosc:throw new  ArgumentException("Liczba powinna być większa od 0");
            _szerokosc = szerokosc>0?szerokosc:throw new  ArgumentException("Liczba powinna być większa od 0");
            _glebokosc = glebokosc>0?glebokosc:throw new  ArgumentException("Liczba powinna być większa od 0");
        }

        #endregion

        #region Metody

        public abstract double Cena();
        public override string ToString() => $"{GetType().Name,-20} {_wysokosc,5} {_szerokosc,5} {_glebokosc,6}";


        #endregion
    }
}