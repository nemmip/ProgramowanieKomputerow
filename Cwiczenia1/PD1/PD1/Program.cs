using System;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            // Prostokat p1 = new Prostokat(20, 30.5);
            // Prostokat p2 = new Prostokat(22.5, 39);
            // Console.WriteLine(p1.ToString());
            // Console.WriteLine(p2.ToString());
            // Console.ReadLine();
            
            //Zadanie 2
            Prostokat[] prostokaty =
            {
                new Prostokat(20, 30.5),
                new Prostokat(22.5, 39),
                new Prostokat(15, 17.25)
            };
            foreach (Prostokat prostokat in prostokaty)
            {
                Console.WriteLine(prostokat.ToString());
            }
            
            //Zadanie 3
            Console.WriteLine($"Maksymalne pole: {Prostokat.MaxPole(prostokaty)}");

            Console.ReadLine();
        }
    }
}