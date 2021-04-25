using System;

namespace z2_13
{
    public static class ZadaniaUruchomienie
    {
        public static void PlanowanieZadan()
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
            Console.ReadLine();
        }

        public static void Kula3D()
        {
            Console.Title = "Kula 3D";
            Punkt3D punkt3D = new Punkt3D(9, 3, 2);
            Kula kula = new Kula(7, 0, 7, 6);
            Console.WriteLine(kula.CzyPunktNalezy(punkt3D) ? "tak" : "nie");
            Console.ReadLine();
        }

        public static void Kwartalniki()
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
            Console.ReadLine();
        }
    }
}