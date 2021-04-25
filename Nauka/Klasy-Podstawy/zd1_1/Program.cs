using System;


namespace zd1_1
{
    class Program
    {
        static void Main(string[] args)
        {   //zadanie1
            /*Paczka p1 = new Paczka("Prioytetowa", 10.5, 12, 45);
            p1.Wyswietl();*/
            //zadanie 2
            /*Paczka[] tablica = new[]
            {
                new Paczka("Priorytetowa", 10.5, 12, 45),
                new Paczka("Ekonomiczna", 12.5, 22, 33),
                new Paczka("Ekonomiczna", 5.3, 10, 30)
            };
            foreach (Paczka paczka in tablica)
            {
                //paczka.Wyswietl();
                Console.WriteLine(paczka);
            }*/
            //zadanie3
            /*double objetosc = Paczka.MaxObjetosc(tablica);
            Console.WriteLine(objetosc);*/
            //zadanie 4
            /*Paczka p1 = new Paczka();
            p1.rodzajPaczki = "Ekonomiczna";    //przypisanie właściwości
            Console.WriteLine(p1);*/
            //zadanie 5
            /*Paczka p1 = new Paczka();
            p1._rodzajPaczki = "Ekonomiczna";
            p1._dlugosc = 10.5;
            p1._szerokosc = 14;
            p1._wysokosc = 25;
            p1._objetosc = p1._dlugosc * p1._szerokosc * p1._wysokosc;
            Console.WriteLine(p1);*/
            // zadanie 7
            Paczka p1 = new Paczka("Priorytetowa", 10.5, 12, 45);
            Console.WriteLine(p1);
            Paczka p2 = new Paczka("Ekonomiczna", 21.2, 24, 15);
            Console.WriteLine(p2);
            Paczka p3 = new Paczka(p2); //konstruktor kopiujący
            Console.WriteLine(p3);
            Console.WriteLine($"Ilość paczek: {Paczka._liczbaPaczek}");
        }
    }
}