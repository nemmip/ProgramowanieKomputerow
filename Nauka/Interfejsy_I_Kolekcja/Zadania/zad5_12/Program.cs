using System;
using System.Collections.Generic;

namespace zad5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Karty> gracz1 = new Queue<Karty>();
            Queue<Karty> gracz2 = new Queue<Karty>();

            Karty.WypelnijKolejke(20,gracz1);
            Karty.WypelnijKolejke(20,gracz2);

            Wojna<Karty> wojna = new Wojna<Karty>(gracz1, gracz2);
            wojna.Gra();
        }
    }
}