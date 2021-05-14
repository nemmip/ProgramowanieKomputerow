using System;
using System.Reflection;

namespace zad2
{
    public class Osoby<T> where T : IOsoba
    {
        private static PropertyInfo[] naglowki;
        private static string kreski = "-----------------------------------------------";

        public static void StworzNaklejke(T obj)
        {
            /*naglowki = typeof(T).GetProperties();

            Console.WriteLine(kreski);
            Console.WriteLine(typeof(T).Name.ToString().ToUpper());
            foreach (PropertyInfo info in naglowki)
            {
                Console.WriteLine($"|{info.Name,-15}{info.GetValue(obj),30}|");
            }

            Console.WriteLine(kreski);*/
            Console.WriteLine(kreski);
            Console.WriteLine(obj.ToString());
            Console.WriteLine(kreski);
        }
    }
}