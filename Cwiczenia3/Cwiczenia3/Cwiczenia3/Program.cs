using System;

namespace Cwiczenia3
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 1
            /*Sprzedaz p1 = new Sprzedaz(12.5, 15, true);
            Sprzedaz p2 = new Sprzedaz(55.99, 7, false);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());*/
            
            // zadanie 2
            /*Console.WriteLine($"Liczba transakcji {Sprzedaz.liczbaTransakcji}");
            Sprzedaz p1 = new Sprzedaz(12.5, 15, true);
            p1.Wyswietl();
            Sprzedaz p2 = new Sprzedaz(55.99, 7, false);
            p2.Wyswietl();
            Sprzedaz p3 = new Sprzedaz(7.85, 24, false);
            p3.Wyswietl();
            Sprzedaz p4 = new Sprzedaz(3.99, 50, true);
            p4.Wyswietl();
            Console.WriteLine($"Liczba transakcji {Sprzedaz.liczbaTransakcji}");*/
            
            
            //zadanie 3 
            /*Sprzedaz p1 = new Sprzedaz(12.5, 15, true);
            p1.Wyswietl();
            Sprzedaz p1Kopia = new Sprzedaz(p1);
            p1Kopia.Wyswietl();
            Sprzedaz p2 = new Sprzedaz(7.85, 24, false);
            p2.Wyswietl();
            Sprzedaz p2Kopia = new Sprzedaz(p2);
            p2Kopia.Wyswietl();*/
            
            //zadanie 4
            /*Agregacja agregacja123 = new Agregacja(new Sprzedaz(2.5, 10),
                new Sprzedaz(4, 6),
                new Sprzedaz(11, 5));*/
            
            Console.WriteLine($"Liczba transakcji {Sprzedaz.liczbaTransakcji}");
           Sprzedaz p1 = new Sprzedaz(12.5, 15, true);
           p1.Wyswietl();
           Sprzedaz p2 = new Sprzedaz(55.99, 7, false);
           p2.Wyswietl();
           Sprzedaz p3 = new Sprzedaz(7.85, 24, false);
           p3.Wyswietl();
           Sprzedaz p4 = new Sprzedaz(3.99, 50, true);
           p4.Wyswietl();
           Console.WriteLine($"Liczba transakcji {Sprzedaz.liczbaTransakcji}");
            
            Console.WriteLine($"Liczba transakcji: {Sprzedaz.liczbaTransakcji}");
            Agregacja agregacja123 = new Agregacja(new Sprzedaz(Dodatki.NettoNaBrutto(2.5,23), 10),
                new Sprzedaz(Dodatki.NettoNaBrutto(3,23), 6),
                new Sprzedaz(Dodatki.NettoNaBrutto(11,23), 5));
            Console.WriteLine($"Liczba transakcji: {Sprzedaz.liczbaTransakcji}");
            agregacja123.Wyswietl();
            

            Console.ReadLine();

        }
    }
}