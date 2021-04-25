using System;

namespace zd1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double FV = Faktura.ObliczFV(100, 10, 3.25);
            Console.WriteLine($"{Faktura.ObliczPV(FV,10,3.25)}");
        }
    }
}