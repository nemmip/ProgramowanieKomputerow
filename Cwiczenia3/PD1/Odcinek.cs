using System;

namespace PD1
{
    public class Odcinek
    {
        #region Pola

        private Punkt _punktA, _punktB;

        #endregion

        #region Konstruktor

        public Odcinek(Punkt A, Punkt B)
        {
            _punktA = A;
            _punktB = B;
        }

        #endregion

        #region Metody

        public double DlugoscOdcinka() =>
            Math.Sqrt(Math.Pow(_punktB.WspolX - _punktA.WspolX, 2) + Math.Pow(_punktB.WspolY - _punktA.WspolY,2));


        #endregion
    }
}