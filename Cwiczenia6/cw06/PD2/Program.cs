using System;

namespace PD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolo[] tab =
            {
                new Kolo(8),
                new Kolo(9),
                new Kolo(2),
                new Kolo(12),
                new Kolo(5),
                new Kolo(4)
            };
            Prostokat[] tab1 =
            {
                new Prostokat(3, 7),
                new Prostokat(4, 9),
                new Prostokat(6, 1),
                new Prostokat(1, 18),
                new Prostokat(2, 5),
                new Prostokat(3, 5),
                new Prostokat(2, 2)
            };
            Console.WriteLine("\n Tablica kół:");
            foreach (Kolo kolo in tab)
                Console.WriteLine(kolo.ToString());
            
            Console.WriteLine("\n Tablica prostokątów");
            foreach (Prostokat prostokat in tab1)
                Console.WriteLine(prostokat.ToString());

        }
    }
}