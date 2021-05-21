using System;
using System.Collections.Generic;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string savePath = @"..\..\zapisanaLista.csv";
            List<Pogoda> lista = Pogoda.GeneratorObiektow(1000);
            List<Pogoda> nowaLista = new List<Pogoda>();
            Pogoda.SaveIntoCSV(lista,savePath);
            Pogoda.LoadFromCSV(nowaLista,savePath);
            Pogoda.Summary(nowaLista);
        }
    }
}