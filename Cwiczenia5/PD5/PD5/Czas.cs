using System;

namespace PD5
{
    public struct Czas
    {
        //pola
        private int _godziny;
        private int _minuty;
        //konstruktor
        public Czas(int godziny, int minuty)
        {
            if (godziny>23 || minuty>59)
                throw new ArgumentException("Niepoprawne argumenty wejściowe");
            else
            {
                _godziny = godziny;
                _minuty = minuty;
            }
        }
        //operatory
        public static Czas operator +(Czas lewy, Czas prawy)
        {
            Czas czas = new Czas();
            //przypisanie godzin
            if (lewy._godziny+prawy._godziny<24)
                czas._godziny = lewy._godziny + prawy._godziny;
            else
                czas._godziny = lewy._godziny + prawy._godziny - 24;
            //przypisanie minut
            if (lewy._minuty + prawy._minuty < 60)
                czas._minuty = lewy._minuty + prawy._minuty;
            else
                czas._minuty = lewy._minuty + prawy._minuty - 60;
            return czas;
        }
        public static Czas operator -(Czas lewy, Czas prawy)
        {
            Czas czas = new Czas();
            //przypisanie godzin
            if (lewy._godziny-prawy._godziny>=0)
                czas._godziny = lewy._godziny - prawy._godziny;
            else
                czas._godziny = -1*(lewy._godziny + prawy._godziny);
            //przypisanie minut
            if (lewy._minuty - prawy._minuty >= 0)
                czas._minuty = lewy._minuty - prawy._minuty;
            else
                czas._minuty = -1*(lewy._minuty - prawy._minuty);
            return czas;
        }
        //metody
        public override string ToString()=>String.Format("{0:0}:{1:00}", this._godziny, this._minuty);
        
    }
}