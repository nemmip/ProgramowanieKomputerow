using System;

namespace z3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Stożki";
            Stozek[] tab =
            {
                new Stozek(10, 15),
                new StozekSciety(8, 12, 3),
                new StozekSciety(10, 15, 1)
            };
            foreach (Stozek stozek in tab)
            {
                Console.WriteLine(stozek.GetType().Name+" "+stozek.PowierzchniaBocznaStozka().ToString("F2"));
            }
        }
    }
}