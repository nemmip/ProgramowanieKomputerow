using System;

namespace Delegaty
{
    class Program
    {
        public delegate int DzialanieDelegat(int x);
        static void Main(string[] args)
        {
            DzialanieDelegat del = new DzialanieDelegat(Oblicz);
            //lub
            DzialanieDelegat del1 = Oblicz;
            Console.WriteLine(del(10));
        }

        static int Oblicz(int x) => x * x - 2 * x;
    }
}