using System;

namespace z1_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Szescian s1;
             s1 = new Szescian();
            s1.KrawedzSzescianu = 9;
            Console.WriteLine($"{s1.Objetosc()}");
            Szescian[] tab = {new Szescian(), new Szescian(), new Szescian(), new Szescian()};
            tab[0].KrawedzSzescianu = 3;
            tab[1].KrawedzSzescianu = 8;
            tab[2].KrawedzSzescianu = 5;
            tab[3].KrawedzSzescianu = 8;
            Szescian.Matrioszka(tab);
        }
    }
}