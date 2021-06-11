using System;
using System.Collections.Generic;

namespace zad5_13
{
    class Program
    {
        private static Dictionary<string, string> slownikSkrotow = new Dictionary<string, string>()
        {
            {"ABT", "około"},
            {"ADR", "adres"},
            {"55", "powodzenia"},
            {"73", "pozdrowienia"},
            {"88", "ucałowania"}
        };

        static void Main(string[] args)
        {
            string zdanie;
            Console.WriteLine("Dodaj zdanie do odkodowania");
            zdanie = Console.ReadLine();
            Console.WriteLine("Odkodowane zdanie:");
            Console.WriteLine(Dekoduj(slownikSkrotow, zdanie));
        }

        private static string Dekoduj(Dictionary<string, string> slownik, string message)
        {
            string[] zdanie = message.Replace(',', ' ').Replace('.', ' ').Split(' ');
            message = String.Empty;
            for (int i = 0; i < zdanie.Length; i++)
            {
                if (slownikSkrotow.ContainsKey(zdanie[i]))
                    zdanie[i] = slownikSkrotow[zdanie[i]];
                message += zdanie[i]+" ";
            }

            return message;
        }
    }
}