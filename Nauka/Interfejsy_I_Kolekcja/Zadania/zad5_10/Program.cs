using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace zad5_10
{
    class Program
    {
        static readonly char[] nawOtw = {'(', '[', '<', '{'};
        static readonly char[] nawZam = {')', ']', '>', '}'};
        static bool PoprawnoscNawiasow(string tekst)
        {
            Stack<char> nawiasy = new Stack<char>();
            foreach (char c in tekst)
            {
                if(nawOtw.Contains(c))
                    nawiasy.Push(c);
                else if (nawZam.Contains(c))
                {
                    if (nawiasy.Count > 0)
                        nawiasy.Pop();
                    else return false;
                }
            }

            return nawiasy.Count == 0;
        }
        static void Main(string[] args)
        {
            string tekst =
                File.ReadAllText(
                    @"C:\Users\julka\source\repos\nemmip\ProgramowanieKomputerow\Nauka\Interfejsy_I_Kolekcja\Zadania\zad5_3\Osoby.cs");
            Console.WriteLine(PoprawnoscNawiasow(tekst));
        }
    }
}