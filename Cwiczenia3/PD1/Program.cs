using System;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie1
            /*Punkt a = new Punkt(1, 4);
            a.Wyswietl();
            a.Przesun(3,5);
            a.Wyswietl();*/
            
            //zadanie 2
            /*Punkt[] tab = new Punkt[3];
            tab[0] = new Punkt(1, 1);
            tab[1] = new Punkt(2, 2);
            tab[2] = new Punkt(3, 3);
            foreach (Punkt punkt in tab)
             punkt.Wyswietl();
            Console.WriteLine(Punkt.NaProstej(tab));*/
            
            //zadanie 3
            Odcinek odcinekAB = new Odcinek(new Punkt(4, 0), new Punkt(4, 6));
            Console.WriteLine(odcinekAB.DlugoscOdcinka());

        }
    }
}