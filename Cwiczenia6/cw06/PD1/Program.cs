using System;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p1 = new Prostokat(5, 10);
            Prostokat p2 = new Prostokat(20, 30);
            Blat b1 = new Blat(2, 1, "drewniany");
            Blat b2 = new Blat(5, 2, "granitowy");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
        }
    }
}