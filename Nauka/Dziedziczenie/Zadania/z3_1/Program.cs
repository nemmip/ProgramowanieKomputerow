using System;

namespace z3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Stożki";
            Stozek s1 = new Stozek(10, 15);
            Console.WriteLine("Stożek "+s1.PowierzchniaBocznaStozka().ToString("F2"));
            StozekSciety s2 = new StozekSciety(8, 12, 3);
            Console.WriteLine("Stożek ścięty "+s2.PowierzchniaBocznaStozkaScietego().ToString("F2"));
        }
    }
}