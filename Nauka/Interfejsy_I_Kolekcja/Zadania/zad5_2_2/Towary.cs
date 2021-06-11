using System;
using System.Collections.Generic;

namespace zad5_2_2
{
    public class Towary<T>:List<T>,IWypisz
    {
        public void Wypisz()
        {
            int numer = 1;
            foreach (T obiekt in this)
            {
                Console.WriteLine(
                    $"{numer++,3} {obiekt.ToString()}");
            }
        }
    }
}