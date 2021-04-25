using System;

namespace z3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojazd[] tab =
            {
                new Coupe(),
                new Balastowy(),
                new Sedan(),
                new Siodlowy()
            };
            foreach (Pojazd pojazd in tab)
            {
                Console.WriteLine(pojazd.ToString());
            }
        }
    }
}