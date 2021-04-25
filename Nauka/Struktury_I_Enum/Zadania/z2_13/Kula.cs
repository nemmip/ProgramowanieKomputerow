using System;

namespace z2_13
{
    public struct Kula
    {
        private int X, Y, Z;
        private int promien;

        public Kula(int X, int Y, int Z, int promien)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.promien = promien;
        }

        public bool CzyPunktNalezy(Punkt3D punkt3D) =>
            Math.Pow(punkt3D.X - X, 2) + Math.Pow(punkt3D.Y - Y, 2) + Math.Pow(punkt3D.Z - Z, 2) <= Math.Pow(promien, 2)
                ? true
                : false;

    }
}