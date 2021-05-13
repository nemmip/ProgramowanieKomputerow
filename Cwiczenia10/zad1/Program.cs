using System;
using System.Collections.Generic;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IFigura> lista = new List<IFigura>
            {
                new Prostokat(8, 5),
                new Kolo(7.7777),
                new Prostokat(4, 6),
                new Kolo(2.5),
                new Kolo(4)
                
            };

            lista.Sort();

            foreach (IFigura figura in lista)
            {
                Console.WriteLine(figura.ToString());
            }
        }

        
    }
}