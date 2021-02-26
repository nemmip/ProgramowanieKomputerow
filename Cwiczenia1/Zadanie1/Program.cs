using System;

namespace Zadanie1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Sprzedaz sprzedaz = new Sprzedaz(20.0, 0.05);
            Sprzedaz sprzedaz2 = new Sprzedaz(30.0, 0.075);
            Console.WriteLine(sprzedaz.ToString());
            Console.WriteLine(sprzedaz2.ToString());
            
            Console.ReadLine();
        }
    }

}