using System;

namespace PD2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pogoda p1 = new Pogoda(new Czas(10, 56), 7, 27,
                KierunekWiatru.polnoc, 47, Zachmurzenie.brak);
            Console.WriteLine(p1.ToString());*/
            
            //tabela
            Pogoda[] tab = new[]
            {
                new Pogoda(new Czas(10, 56), 7, 27,
                    KierunekWiatru.polnoc, 47, Zachmurzenie.brak),
                new Pogoda(new Czas(17, 00), 8, 54,
                    KierunekWiatru.poludnie, 43, Zachmurzenie.male),
                new Pogoda(new Czas(23, 02), 5, 36,
                    KierunekWiatru.zachod, 47, Zachmurzenie.duze)
            };
            Pogoda.WyswietlTabele(tab);
        }
    }
}