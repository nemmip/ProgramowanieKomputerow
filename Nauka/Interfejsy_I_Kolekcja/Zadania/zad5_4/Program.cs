using System;

namespace zad5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Analiza nawiasów";
            Console.Write(("Podaj wyrażenie: "));
            string wyrazenie = Console.ReadLine();
            if(AnalizaNawiasow.SprawdzNawiasy(wyrazenie))
                Console.WriteLine("Wyrażenie jest prawidłowe");
            else
                Console.WriteLine("Wyrażenie jest nieprawidłowe");
        }
    }
}