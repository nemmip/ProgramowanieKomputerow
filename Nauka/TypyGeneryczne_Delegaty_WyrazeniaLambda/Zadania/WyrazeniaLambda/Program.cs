using System;

namespace WyrazeniaLambda
{
    delegate int ObliczDelegat(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            /*ObliczDelegat oblicz1 = (x1, x2) => x1 * x2 + 2 * x1;
            ObliczDelegat oblicz2 = (x1, x2) =>
            {
                int mnoznik = 2;
                return x1 * x2 + mnoznik * x1;
            };
            Console.WriteLine(oblicz1(2,3));
            Console.WriteLine(oblicz2(2,3));*/
            int x = 1;
            Func<int, int> wynik = n => n * x;
            x = 10;
            Console.WriteLine(wynik(2));
        }
    }
}