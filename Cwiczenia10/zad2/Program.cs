using System;
using System.Collections.Generic;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOsoba> list = new List<IOsoba>()
            {
                new Klient
                {
                    Imie = "Jolanta", Nazwisko = "Allo", Miasto = "Bydgoszcz", Ulica = "Jurajska", NumerDomu = "22A"
                },
                new Klient {Imie = "Adam", Nazwisko = "Fajny", Miasto = "Kraków", Ulica = "Wawelska", NumerDomu = "30"},
                new Pracownik
                {
                    Imie = "Ireneusz", Nazwisko = "Bombka", Miasto = "Wrocław", Ulica = "Krasnoludków",
                    NumerDomu = "8/30", Kryterium = Kryterium.miasto
                },
                new Pracownik
                    {Imie = "Wiesława", Nazwisko = "Ile", Miasto = "Sopot", Ulica = "Słoneczna", NumerDomu = "120B"}
            };
            foreach (IOsoba osoba in list)
            {
                /*string a = osoba.GetType().Name;
                if (a=="Pracownik")
                {
                    Pracownik temp = osoba as Pracownik;
                    Osoby<Pracownik>.StworzNaklejke(temp);
                }
                else
                {
                    Klient temp = osoba as Klient;
                    Osoby<Klient>.StworzNaklejke(temp);
                }*/
                Osoby<IOsoba>.StworzNaklejke(osoba);
            }

            list.Sort();
            Console.WriteLine("############################");
            foreach (IOsoba osoba in list)
            {
                Osoby<IOsoba>.StworzNaklejke(osoba);
            }
        }
        
    }
}