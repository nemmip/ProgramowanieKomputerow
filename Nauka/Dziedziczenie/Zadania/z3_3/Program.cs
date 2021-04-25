using System;

namespace z3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ciasto Pizzy";
            Kolo[] tab =
            {
                new Kolo(15),
                new CiastoPizzy(15, RodzajCiasta.CienkieCiasto),
                new CiastoPizzy(30, RodzajCiasta.GrubeCiasto)
            };
            foreach (Kolo k1 in tab)
            {
                Console.WriteLine(k1.ToString());
            }
            Console.WriteLine(tab[1].Equals(tab[2]));
        }
    }
}