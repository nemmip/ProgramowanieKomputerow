using System;
using System.Collections.Generic;

namespace zad5_5
{
    class Program
    {
        static void Wypisz(Queue<Osoba> osoby)
        {
            int numer = 1;
            Console.WriteLine("liczba osób w kolejce: "+osoby.Count);
            foreach (Osoba osoba in osoby)
            {
                Console.WriteLine($"{numer++,3} {osoba.ToString()}");
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Kolejka osób";
            Queue<Osoba> wKolejce = new Queue<Osoba>();
            wKolejce.Enqueue(new Osoba("Dariusz","Tkacz"));
            wKolejce.Enqueue(new Osoba("Zofia","Nowak"));
            wKolejce.Enqueue(new Osoba("Jan","Kowalski"));
            wKolejce.Enqueue(new Osoba("Ewa","Nowak"));
            wKolejce.Enqueue(new Osoba("Adam","Kowalski"));
            Wypisz(wKolejce);
            int i = 0;
            if (int.TryParse(Console.ReadLine(), out int liczbaMieszkan))
            {
                liczbaMieszkan = Math.Min(liczbaMieszkan, wKolejce.Count);
                while (i++<liczbaMieszkan)
                {
                    Console.WriteLine("Mieszkanie dla "+ wKolejce.Dequeue().ToString());
                }
            }
            Console.WriteLine();
            Wypisz(wKolejce);
            
        }
    }
}