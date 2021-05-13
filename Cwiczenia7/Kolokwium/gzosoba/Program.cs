using System;

namespace gzosoba
{
    class Program
    {
        static void Main(string[] args)
        {
            //tutaj tablica na obiekty
            Osoba[] tab = new Osoba[5];
            do
            {
                foreach (Osoba osoba in tab)
                    Console.WriteLine(osoba.ToString());
                Menu();
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                WyswietlGrupe(consoleKey,tab);
                
            } while (true);

            
        }

        static void Menu()
        {
            Console.WriteLine("######MENU######");
            Console.WriteLine("Wybierz grupę:");
            Console.WriteLine("[1] Informatyk");
            Console.WriteLine("[2] Kierownik");
        }

        static void WyswietlGrupe(ConsoleKeyInfo key1, Osoba[]tab)
        {
            ConsoleKey key = key1.Key;
            
            if (key==ConsoleKey.D1)
            {
                foreach (Osoba osoba in tab)
                {
                    if (osoba.Stanowisko == Stanowisko.informatyk)
                    {
                        Console.WriteLine(osoba.ToString());
                    }
                }
            }
            else if (key == ConsoleKey.D2)
            {
                foreach (Osoba osoba in tab)
                {
                    if (osoba.Stanowisko == Stanowisko.kierownik)
                    {
                        Console.WriteLine(osoba.ToString());
                    }
                }
            }
            else if(((char)key>64 && (char)key<91)||((char)key>96 &&(char)key<123)||key==ConsoleKey.Z)
                Environment.Exit(0);
            
        }
    }
}