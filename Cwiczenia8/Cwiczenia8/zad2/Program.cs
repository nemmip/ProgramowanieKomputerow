using System;
using System.Linq;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> action = x => Console.Write($"{x,10}");
            Action<Karta> action1 = y => Console.Write($"{y,20}");

            int[] ar = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            /*foreach (int i in ar)
            {
                Console.Write($"{i,10}");
            }*/
            Array.ForEach(ar,action);
            Shuffle(ar);
            Console.WriteLine("\n");
            Array.ForEach(ar,action);
            /*foreach (int i in ar)
            {
                Console.Write($"{i,10}");
            }*/

            Karta[] kartas = new[]
            {
                new Karta(kolorKarty.pik, nazwaKarty.dziewiatka),
                new Karta(kolorKarty.trefl, nazwaKarty.szostka),
                new Karta(kolorKarty.trefl, nazwaKarty.@as),
                new Karta(kolorKarty.pik, nazwaKarty.dama),
                new Karta(kolorKarty.trefl, nazwaKarty.piatka)
            };
            Console.WriteLine("\n");
            Array.ForEach(kartas,action1);
            /*foreach (Karta i in kartas)
            {
                Console.Write($"{i,20}");
            }*/
            
            Shuffle(kartas);
            Console.WriteLine("\n");
            Array.ForEach(kartas,action1);
            /*foreach (Karta i in kartas)
            {
                Console.Write($"{i,20}");
            }*/
        }

        static void Shuffle<T>(T[] array)
        {
            
            int lenght = array.Length;
            Random random = new Random();
            T temp;
            for (int i = lenght-1; i > 0; i--)
            {
                int los = random.Next(i+1);
                temp = array[i];
                array[i] = array[los];
                array[los] = temp;
            }
            
        }
        
    }
}