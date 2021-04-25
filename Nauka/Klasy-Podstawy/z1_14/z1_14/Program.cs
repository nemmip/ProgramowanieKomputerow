using System;

namespace z1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Energia pomiar = new Energia(0, 0.75);
            Console.WriteLine(pomiar.PoczatkowyStan);
            Console.WriteLine(pomiar.BiezacyStan);
            pomiar.BiezacyStan = 1.25;
            Console.WriteLine(pomiar.BiezacyStan);
            Console.WriteLine(pomiar.ZuzytaEnergia());
        }
    }
}