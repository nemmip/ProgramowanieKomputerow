using System;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz tekst: ");
            Lancuch lancuch = new Lancuch(Console.ReadLine());
            //Console.WriteLine(lancuch.ZwrocLiczbe());
            Console.WriteLine(lancuch.ZmienLitery());
            Console.ReadLine();
        }
    }
}