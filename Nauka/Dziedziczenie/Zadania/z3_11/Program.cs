using System;

namespace z3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierz[] tab =
            {
                new Kot(),
                new Papuga()
            };
            foreach (Zwierz zwierz in tab)
            {
                Console.WriteLine(zwierz.ToString());
            }
            // po zmianie override na new zostaje wywolana metoda bazowa, nie pochodna
        }
    }
}