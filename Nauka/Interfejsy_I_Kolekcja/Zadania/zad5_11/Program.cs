using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5_11
{
    class Program
    {
        static int Wynik()
        {
            Stack<Karty> stosKart = new Stack<Karty>();
            Random random = new Random();
            int sum = 0;
            do
            {
                Console.WriteLine("Suma wynosi " + sum);
                Console.WriteLine("Pobrać kartę?");
                if (Console.ReadLine() == "y")
                {
                    stosKart.Push((Karty) random.Next(2,15));
                    Console.WriteLine($"Wylosowano: {stosKart.Peek()}");
                    sum = stosKart.Sum((x) =>
                    {
                        if((byte) x >8)
                        {
                            switch (x)
                            {
                                case Karty.Walet: return 2;
                                case Karty.Dama: return 3;
                                case Karty.Krol: return 4;
                                case Karty.As: return 11;
                                default: break;
                            }
                        }

                        return (byte) x;
                    });
                }
                else
                {
                    return sum;
                }
            } while (sum < 22);

            return sum;
        }
        static void Main(string[] args)
        {
            int wynik = Wynik();
            Console.WriteLine($"Koniec gry! Twój wynik to {wynik}. ");
            Console.WriteLine(wynik == 21 ? "Wygrałeś!" : "Przegrałeś!");
        }
    }
}