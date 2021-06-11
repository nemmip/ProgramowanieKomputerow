using System;
using System.Collections.Generic;

namespace zad5_6
{
    class Program
    {
        private static Dictionary<string, string> slownik = new Dictionary<string, string>()
        {
            {"wg", "według"},
            {"np.", "na przykład"},
            {"itd.", "i tak dalej"},
            {"itp.", "i tym podobne"},
            {"m.in.", "między innymi"}
        };

        static string ZamienTekst(string zdanie)
        {
            string noweZdanie = String.Empty;
            string separator = String.Empty;
            string[] tab = zdanie.Split(' ');
            for (int i = 0; i < tab.Length; i++)
            {
                separator = (i == 0) ? separator : " ";
                if (slownik.ContainsKey(tab[i]))
                    noweZdanie += separator + slownik[tab[i]];
                else
                    noweZdanie += separator + tab[i];
            }

            return noweZdanie;
        }
        static void Main(string[] args)
        {
            Console.Title = "Słownik skrótów";
            slownik.Add("CV", "nie wiem");
            slownik.Add("tj.","to jest");
            slownik["CV"] = "curriculum vitae";

            string tekst;
            if (slownik.TryGetValue("CV", out tekst))
            {
                Console.WriteLine(tekst);
            }
            Console.WriteLine(slownik.ContainsKey("wg"));
            Console.WriteLine(slownik.ContainsValue("to jest"));
            slownik.Remove("tj.");
            foreach (KeyValuePair<string,string> x in slownik)
            {
                Console.WriteLine(x.Key+"-" +x.Value);
            }

            string zdanie = "Napisał CV wg moich wskazówek i wysłał m.in. do naszej firmy.";
            Console.WriteLine(zdanie);
            Console.WriteLine(ZamienTekst(zdanie));
        }
    }
}