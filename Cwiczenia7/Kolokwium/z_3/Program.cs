using System;
using System.Collections.Generic;

namespace z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Klient[] tab =
            {
                new Hurtowy("Anna", "Kowalska", 10, 5),
                new Hurtowy("Adam", "Jan", 25, 80),
                new DetalicznyOkaz("Joanna", "Spik", 15, 20),
                new DetalicznyOkaz("Olaf", "Ubo", 50, 90),
                new DetalicznyStaly("Ewelina","Malwina",100,5,5),
                new DetalicznyStaly("Agata","Kulesza",80,10,8)
            };
            Klient.Sortuj(tab);
            foreach (Klient klient in tab)
            {
                Console.WriteLine(klient.ToString());
            }
            
            
        }
    }
}