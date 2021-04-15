using System;

namespace PD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Wektor wektor1 = new Wektor(new []{1,2,0});
            wektor1.Wyswietl();
            Wektor wektor2 = new Wektor(new[] {3, 1, -1});
            wektor2.Wyswietl();
            Console.WriteLine($"Iloczyn skalarny: {Wektor.IloczynSkalarny(wektor1,wektor2)}");
            Console.ReadLine();
        }
    }
}