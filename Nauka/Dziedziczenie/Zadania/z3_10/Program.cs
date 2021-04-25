using System;

namespace z3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Danie[] tab =
            {
                new Danie("Rosół", 250, 500, 22, 8),
                new Danie("Klopskiki z ryżem", 700, 500, 30, 20),
                new WegeDanie("Frytki", 150, 350, 15, 5, 0.5, 25),
                new WegeDanie("Pomidorowa", 250, 200, 22, 7, 2.5, 50)
            };
            foreach (Danie danie in tab)
            {
                Console.WriteLine(danie.ToString());
            }
        }
    }
}