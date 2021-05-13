using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba[] tab = new Osoba[]
            {
                new Klient("Andżela", "Błoga", "85-000", "Bydgoszcz", "Kościuszki", 17, 32),
                new Klient("Brajan", "Brytyjski", "25-004", "Kielce", "Marii Skłodowskiej-Curie", 65),
                new Pracownik("Wiesław", "Daspedowski", "60-001", "Poznań", "Słowackiego", 687),
                new Pracownik("Jacek", "Wrona", "90-000", "Łódź", "Kowalska", 8, 160)
            };
            foreach (Osoba osoba in tab)
            {
                Naklejka<Osoba>.StworzNaklejke(osoba);
            }
        }
    }
}