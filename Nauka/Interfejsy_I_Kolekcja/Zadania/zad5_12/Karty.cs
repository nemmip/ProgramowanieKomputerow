using System;
using System.Collections.Generic;

namespace zad5_12
{
    public class Karty:IComparable<Karty>
    {
        private static readonly Random _random = new Random();
        private Rewers _rewers;
        public Rewers Rewers { get=>_rewers;}

        public Karty(Rewers rewers)
        {
            this._rewers = rewers;
        }

        public static  void WypelnijKolejke(int liczbaKart, Queue<Karty> kolejka)
        {
            for (int i = 0; i < liczbaKart; i++)
            {
                kolejka.Enqueue(new Karty((Rewers)_random.Next(6,15)));
            }
        }
        public int CompareTo(Karty? other)
        {
            if (other == null) return 1;
            return Rewers.CompareTo(other.Rewers);
        }
    }
}