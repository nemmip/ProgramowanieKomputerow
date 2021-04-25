using System;

namespace z2_12
{
    public struct Kolo
    {
        private double promien;
        private int X, Y;

        public Kolo(double promien, int X, int Y)
        {
            this.promien = promien;
            this.X = X;
            this.Y = Y;
        }

        public static Kolo operator +(Kolo kolo, double promien) => new Kolo(kolo.promien + promien, kolo.X, kolo.Y);

        public static bool operator <(Kolo k1, Kolo k2)
        {
            bool wyjscie = false;
            //czy k1 jest mniejsze od k2
            if (k1.promien < k2.promien)
            {
                //jesli tak, to sprawdz wzajemne położenie okręgów
                //warunek 0<=d<=|r1-r2|
                //gdzie d to odległość między środkami okręgów
                double d = Math.Sqrt(Math.Pow(k2.X - k1.X, 2) + Math.Pow(k2.Y - k1.Y, 2));
                if (0 <= d && d <= Math.Abs(k1.promien - k2.promien))
                    wyjscie = true;
            }

            return wyjscie;
        }
        public static bool operator >(Kolo k1, Kolo k2)
        {
            bool wyjscie = false;
            //czy k1 jest mniejsze od k2
            if (k1.promien > k2.promien)
            {
                //jesli tak, to sprawdz wzajemne położenie okręgów
                //warunek 0<=d<=|r1-r2|
                //gdzie d to odległość między środkami okręgów
                double d = Math.Sqrt(Math.Pow(k2.X - k1.X, 2) + Math.Pow(k2.Y - k1.Y, 2));
                if (0 <= d && d <= Math.Abs(k2.promien - k1.promien))
                    wyjscie = true;
            }

            return wyjscie;
        }
        
        

    }
}