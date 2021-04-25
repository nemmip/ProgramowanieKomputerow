using System;

namespace z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Szafa[] tab =
            {
                new SzafaWnekowa(1, 2, 3),
                new SzafaWnekowa(2, 3, 0.5),
                new SzafaWolnostojaca(1, 2, 3),
                new SzafaWolnostojaca(2, 3, 0.5)
            };
            foreach (Szafa szafa in tab)
            {
                Console.WriteLine(szafa.ToString());
            }

            Console.ReadLine();
        }
    }
}