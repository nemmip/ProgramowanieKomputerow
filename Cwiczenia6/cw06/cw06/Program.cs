using System;

namespace cw06
{
    class Program
    {
        static void Main()
        {
            /*Console.WriteLine("\n Po prostu pies: ");
            Pies burek = new Pies();
            burek.Imie = "Argos";
            
            burek.rysuj();
            burek.szczekaj();
            burek.szkolenia();*/
            //burek.rasa(); 
            //relacja dziedziczenia nie jest dwustronna - dziedziczą potomkowie, nie protoplaści
            Console.WriteLine("\n Pies rasowy: ");
            PiesRasowy rafik = new PiesRasowy();
            rafik.Imie = "Rafaello";
            rafik.Umaszczenie = "biało-rudy";
            rafik.prezentacja();
            rafik.rysuj();
            rafik.glos();
            
            Console.WriteLine("\n Po prostu kot: ");
            Kot mruczek = new Kot();
            mruczek.Imie = "Bonifacy";
            mruczek.Umaszczenie = "czarny";
            mruczek.JakPije = "miseczka";
            mruczek.prezentacja();
            mruczek.rysuj();
            mruczek.glos();
            
            /*Console.WriteLine("\n Po prostu zwierz: ");
            Zwierz jakis = new Zwierz();
            jakis.Imie = "Dyzio";
            jakis.Umaszczenie = "zielony";
            jakis.prezentacja();
            Console.WriteLine($"{jakis.Imie} ma {jakis.Wiek} lat.");*/
            
            /*Console.WriteLine("\n Tablica psów: ");
            Pies[] psy =
            {
                new Pies(),
                new Pies(),
                new PiesRasowy(),
                new PiesRasowy()
            };
            foreach (Pies pies in psy)
            {
                Console.WriteLine(pies.GetType().Name); //sprawdzenie którego typu jest obiekt Pies
                pies.szkolenia();
            }*/
            //przykrywanie metody w klasie pochodnej -> słowo kluczowe new -> nie zostanie wykorzystane przy typach referencyjnych
            //nadpisanie metody -> w pochodnej override, w bazowej virtual lub abstract -> działa na referencję
            
            //klasa abstrakcyjna -> można założyć że zawsze będzie klasą bazową dla innych klas
            // jej obiekty są na tyle ogólne, ze nie ma żadnego uzasadnienia, ze nie ma potrzeby tworzenia jej obiektów
            Console.ReadKey();
        }
    }
}