using System;

namespace PD2
{
    public struct Pogoda
    {
        //pola
        private Czas czasPomiaru;
        private double temperatura;
        private double predkoscWiatru;
        private KierunekWiatru kierunekWiatru;
        private double wilgotnosc;
        private Zachmurzenie zachmurzenie;
        //konstruktor
        public Pogoda(Czas czasPomiaru, double temperatura, double predkoscWiatru, KierunekWiatru kierunekWiatru,
            double wilgotnosc, Zachmurzenie zachmurzenie)
        {
            this.czasPomiaru = czasPomiaru;
            this.temperatura = temperatura;
            this.predkoscWiatru = predkoscWiatru;
            this.kierunekWiatru = kierunekWiatru;
            this.wilgotnosc = wilgotnosc;
            this.zachmurzenie = zachmurzenie;
        }
        
        //metody
        public override string ToString()
        {
            return $"{czasPomiaru,-5}{temperatura + "°C",15}{predkoscWiatru + "km/h",20}{kierunekWiatru,20}" +
                   $"{wilgotnosc + "%",15}{zachmurzenie,15}";
        }

        public static void WyswietlTabele(Pogoda[] tab)
        {
            Console.WriteLine($"{"Czas Pomiaru",-5}{"Temperatura",15}{"Prędkość Wiatru",20}{"Kierunek Wiatru",20}" +
                              $"{"Wilgotność",15}{"Zachmurzenie",15}");
            foreach (Pogoda pogoda in tab)
            Console.WriteLine(pogoda.ToString());
        }
    }
}