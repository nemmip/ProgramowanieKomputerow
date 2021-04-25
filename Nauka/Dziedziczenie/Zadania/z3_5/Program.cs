using System;

namespace z3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pracownicy";
            Pracownik[] tab =
            {
                new Handlowiec("Alina", "Kowalska", 0.2, 45900.0),
                new Handlowiec("Olga", "Dobra", 0.1, 41340.0),
                new Kierowca("Adam", "Kowalski", 170, 20.0)
            };
            foreach (Pracownik p in tab)
            {
                Console.WriteLine(p.ToString());
            }

           // Pracownik p1 = new Pracownik("Jan", "Kowalski"); //bład!
           
        }
    }
}