using System;
using System.Reflection;

namespace zad6
{
    public class TablicaObiektow<T> where T:class
    {
        private static PropertyInfo[] _tablicaWlasciwosci;

        public static void Opis(T obj)
        {
            _tablicaWlasciwosci = typeof(T).GetProperties();
            foreach (PropertyInfo info in _tablicaWlasciwosci)
            {
                Console.WriteLine($"{info.Name+":",-10}{info.GetValue(obj),15}");
            }
            Console.WriteLine("--------------------------");
        }
    }
}