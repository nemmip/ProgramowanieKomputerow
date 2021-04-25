using System;

namespace z2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolo k1 = new Kolo(5, 0, 0);
            Kolo k2 = new Kolo(12, 0, 0);
            Console.WriteLine(k2>k1);
        }
    }
}