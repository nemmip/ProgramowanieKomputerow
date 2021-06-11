using System;

namespace zad6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Analiza znaków w pliku";
            string plik = @"..\..\MetodyKlasyMath.txt";
            AnalizaZnakow obj = new AnalizaZnakow(plik);
            obj.WykonajAnalize();
            obj.WypiszListeZnakow();
        }
    }
}