using System;

namespace z2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwartalnik[] tab =
            {
                new Kwartalnik("Kubuk", Kwartal.I, 2021),
                new Kwartalnik("Przekój", Kwartal.II, 2021),
                new Kwartalnik("Murator", Kwartal.III, 2021),
                new Kwartalnik("Teraz Rock", Kwartal.IV, 2020)
            };
            foreach (Kwartalnik kwartalnik in tab)
            {
                Console.WriteLine(kwartalnik.ToString());
            }
        }
    }
}