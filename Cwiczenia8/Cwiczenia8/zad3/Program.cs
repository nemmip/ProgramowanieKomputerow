using System;
using System.Collections;
using System.Collections.Generic;

namespace zad3
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Action<int> Wysw = x => Console.Write($"{x,-5}");
            Action<double> WyswD = x => Console.Write($" {x,-5}");
            int[] ar1 = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Shuffle(ar1);
            Array.ForEach(ar1, Wysw);
            Sortuj(ar1);
            Console.WriteLine();
            Array.ForEach(ar1,Wysw);
            
            Console.WriteLine();
            double[] ar2 = new[] {0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8,0.9,1.0};
            Shuffle(ar2);
            Array.ForEach(ar2,WyswD);
            Sortuj(ar2);
            Console.WriteLine();
            Array.ForEach(ar2,WyswD);

        }

        static void Sortuj<T>(T[] tab) where T : IComparable<T>
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                    if(tab[j-1].CompareTo(tab[j])>0)
                        Zamien(tab,j-1,j);
                }
            }
        }
        static void Zamien<T>(T[] tab, int indeks1, int indeks2)
        {
            T temp = tab[indeks1];
            tab[indeks1] = tab[indeks2];
            tab[indeks2] = temp;
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