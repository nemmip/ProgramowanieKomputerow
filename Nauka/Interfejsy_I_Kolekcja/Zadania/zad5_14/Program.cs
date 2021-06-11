using System;
using System.Collections.Generic;

namespace zad5_14
{
    class Program
    {
        private static Dictionary<string, Znaczenie> slownikSkrotow = new Dictionary<string, Znaczenie>()
        {
            {"ABT", new Znaczenie("około","approx")},
            {"ADR", new Znaczenie("adres","address")},
            {"55", new Znaczenie("powodzenia","Godspeed")},
            {"73", new Znaczenie("pozdrowienia","greetings")},
            {"88",new Znaczenie( "ucałowania","love")}
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz zdanie do dekodowania");
            string zdanie = Console.ReadLine();
            Console.WriteLine("Wybierz język polski PL / angielski ENG");
            string jezyk = Console.ReadLine();
            Console.WriteLine(WybranyJezyk(ref jezyk)?Dekoduj(slownikSkrotow,zdanie,jezyk):"Niepoprawny jezyk!");
            
        }
        private static string Dekoduj(Dictionary<string, Znaczenie> slownik, string message, string jezyk)
        {
            string[] zdanie = message.Replace(',', ' ').Replace('.', ' ').Split(' ');
            message = String.Empty;
            if (jezyk == "Polski")
            {
                for (int i = 0; i < zdanie.Length; i++)
                {
                    if (slownikSkrotow.ContainsKey(zdanie[i]))
                        zdanie[i] = slownikSkrotow[zdanie[i]].Polski;
                    message += zdanie[i] + " ";
                }
            }
            else
            {
                for (int i = 0; i < zdanie.Length; i++)
                {
                    if (slownikSkrotow.ContainsKey(zdanie[i]))
                        zdanie[i] = slownikSkrotow[zdanie[i]].Angielski;
                    message += zdanie[i] + " ";
                }
            }

            return message;
        }

        static bool WybranyJezyk(ref string jezyk)
        {
            if (jezyk == "PL")
            {
                jezyk = "Polski";
                return true;
            }
            else if (jezyk == "ENG")
            {
                jezyk = "Angielski";
                return true;
            }
            else return false;
        }
    }
}