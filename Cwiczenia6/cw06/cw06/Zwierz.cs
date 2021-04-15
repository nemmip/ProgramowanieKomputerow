using System;

namespace cw06
{
    abstract class Zwierz //klasa abstrakcyjna umożliwia tworzenie metod abstrakcyjnych
    {
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public string Umaszczenie { get; set; }

        public void prezentacja()
        {
            Console.WriteLine($"Jestem zwierz {Umaszczenie},jestem typem {GetType().Name} a na imię mam {Imie}");
        }
        // aby metoda mogła być bezwzględnie mogła zostać użyta w klasach pochodnych należy użyć modyfikatora abstract
        public abstract void glos();//nie można zaimplementować metody abstrakcyjnej w klasie abstrakcyjnej


    }
}