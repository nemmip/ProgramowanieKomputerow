using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool warunek = default;
            string message = default, wejscie = default;
            
            do
            {
                Console.WriteLine("Podaj długość boku kwadratu:");
                wejscie = Console.ReadLine();
                warunek = int.TryParse(wejscie, out int bok) && bok >= 0;
                message = warunek ? "Twoje pole wynosi " + bok * bok : "Błąd!";
                Console.WriteLine(message);
            } while (!warunek);

            Console.ReadLine();
        }
    }
}
