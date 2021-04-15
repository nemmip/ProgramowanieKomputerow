using System;
using Microsoft.VisualBasic;

namespace PD2
{
    public struct Czas
    {
        private int godziny;
        private int minuty;

        public Czas(int godziny, int minuty)
        {
            if (godziny>24 || minuty>59)
                throw new ArgumentException("Błędnie podana godzina!");
            else
            {
                this.godziny = godziny;
                this.minuty = minuty;
            }
        }

        public override string ToString() => String.Format("{0:00}:{1:00}", this.godziny, this.minuty);


    }
}