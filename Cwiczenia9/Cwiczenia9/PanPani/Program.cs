using System;
using System.Collections.Generic;

namespace PanPani
{
    class Program
    {
        
        /*public Action<bool, Osoba> Wyswietl = (plec, osoba) =>
            Console.WriteLine(plec ? $"Pani {osoba.ToString()}" : $"Pan {osoba.ToString()}");*/
        
        static void Main(string[] args)
        {
            Action<bool, Osoba> Wyswietl = (plec, osoba) =>
                Console.WriteLine(plec ? $"Pani {osoba.ToString()}" : $"Pan {osoba.ToString()}");
            Func<Osoba, bool> Plec = osoba => osoba._imie[osoba._imie.Length - 1] == 'a' ? true : false;
            
            List<Osoba> list = new List<Osoba>(new[]
            {
                new Osoba("Julia", "Ziębińska"),
                new Osoba("Sławomir", "Jarek")
            });

            foreach (Osoba osoba in list)
            {
                Wyswietl(Plec(osoba), osoba);
            }

            

        }
    }
}