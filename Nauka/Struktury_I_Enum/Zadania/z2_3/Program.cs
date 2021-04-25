using System;

namespace z2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zadania - dziś jest " + DateTime.Now.ToShortDateString();
            Zadanie[] tabZadania = new Zadanie[5];
            tabZadania[0] = new Zadanie("Napisanie referatu", PriorytetZadania.Wysoki,
                new DateTime(2020, 10, 20, 0, 0, 0));
            tabZadania[1] = new Zadanie("Posprzątanie pokoju", PriorytetZadania.Sredni, new DateTime(2021, 10, 17));
            tabZadania[2] = new Zadanie("Wysłanie listu", PriorytetZadania.Wysoki, new DateTime(2021, 10, 19, 0, 0, 0));
            tabZadania[3] = new Zadanie("Biblioteka", PriorytetZadania.Sredni, new DateTime(2021, 10, 26));
            tabZadania[4] = new Zadanie("Kupno telefonu", PriorytetZadania.Niski, new DateTime(2021, 10, 10));
            tabZadania[1].CzyWykonane = true;
            foreach (Zadanie zadanie in tabZadania)
                Console.WriteLine(zadanie.ToString());

        }
    }
}