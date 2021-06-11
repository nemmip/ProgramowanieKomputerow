using System;
using System.Collections.Generic;

namespace zad5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lista liczb";
            List<int> liczby = new List<int> {9, 7, 5};
            liczby.Add(4);
            liczby.Add(1);
            liczby.Add(2);
            Console.WriteLine("Pokaż elementy listy");
            foreach (int i in liczby)
            {
                Console.WriteLine(i.ToString());
            }
            liczby.Insert(3,6); //wstaw element
            liczby.Remove(9);   //usuń element o wartości 9
            liczby.RemoveAt(3); //usuń element o indeksie 3
            liczby.Sort();  //sortuj liste
            
            Console.WriteLine("Pokaż końcową postać listy");
            for (int i = 0; i < liczby.Count; i++)
            {
                Console.WriteLine(liczby[i].ToString());
            }
        }
    }
}