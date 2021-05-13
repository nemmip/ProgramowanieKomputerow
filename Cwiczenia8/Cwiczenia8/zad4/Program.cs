using System;
using Microsoft.VisualBasic.CompilerServices;

namespace zad4
{
    class Program
    {
        public delegate bool Compare<T>(T obj1, T obj2);
        static void Main(string[] args)
        {
            Action<Car> wysw = x => Console.WriteLine(x);
            Car[] tab = new[]
            {
                new Car("Audi", "A4B6", 2004, 420000, 1.9),
                new Car("Hyundai", "Coupe FL2", 2007, 160000, 2.0),
                new Car("Mercedes","C200",1999,120000,1.8),
                new Car("Seat","Ibiza",2002,333000,1.6)
                
            };
           Compare<Car> porownywarka = new Compare<Car>(Car.Porownaj);
            Console.WriteLine(Car.Kryterium);
            Sortuj(tab,porownywarka);
            Array.ForEach(tab,wysw);
            
            Car.Kryterium = KrytSamochod.pojemnosc;
            Console.WriteLine("\n"+Car.Kryterium);
            Sortuj(tab,porownywarka);
            Array.ForEach(tab,wysw);
            
            Car.Kryterium = KrytSamochod.pojemnosc;
            Console.WriteLine("\n"+Car.Kryterium);
            Sortuj(tab,porownywarka);
            Array.ForEach(tab,wysw);

        }
        static void Sortuj<T>(T[] tab, Compare<T> compare)
        {
            
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                    if(compare(tab[j-1],tab[j]))
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
    }
}