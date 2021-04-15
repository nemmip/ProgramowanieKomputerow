using System;

namespace PD3
{
    class Program
    {
        static void Main(string[] args)
        {

            Znaki[] tab = new Znaki [30];

            tab[0] = new Znaki(5, 5, '*');
            tab[1] = new Znaki(60, 10, '+');
            tab[2] = new Znaki(55, 14, '*');
            tab[3] = new Znaki(34, 11, '#');
            tab[4] = new Znaki(34, 11, '*');
            for (int i = 5; i < tab.Length; i++)
            {
                tab[i] = new Znaki();
            }

            foreach (Znaki znaki in tab)
            {
                znaki.WyswietlPunkty();
            }

            Console.ReadLine();


        }
    }
}