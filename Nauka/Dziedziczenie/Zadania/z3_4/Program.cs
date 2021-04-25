using System;

namespace z3_4
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
                new CiastoPizzy(15, RodzajCiasta.CienkieCiasto)
            };
            foreach (Kolo k1 in tab)
            {
                Console.Write($"{k1.GetHashCode(),5} ");
                Console.WriteLine(k1.ToString());
            }
            Console.WriteLine(tab[1].Equals(tab[2]));
        }
    }
}