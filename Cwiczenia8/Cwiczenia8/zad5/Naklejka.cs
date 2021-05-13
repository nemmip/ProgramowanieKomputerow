using System;
using System.Linq;
using System.Reflection;

namespace zad5
{
    public class Naklejka<T> where T:Osoba
    {
        private static PropertyInfo[] naglowki;
        private static string kreski = "-----------------------------------------------";
        public static void StworzNaklejke(T obj)
        {
            naglowki = typeof(T).GetProperties();

            Console.WriteLine(kreski);
            foreach (PropertyInfo info in naglowki)
            {
                Console.WriteLine($"|{info.Name,-15}{info.GetValue(obj),30}|");
            }
            Console.WriteLine(kreski);
        }
        
    }
}