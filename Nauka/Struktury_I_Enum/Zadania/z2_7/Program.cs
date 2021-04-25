using System;

namespace z2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt3D punkt3D = new Punkt3D(9, 3, 2);
            Kula kula = new Kula(7, 0, 7, 6);
            Console.WriteLine(kula.CzyPunktNalezy(punkt3D) ? "tak" : "nie");
        }
    }
}