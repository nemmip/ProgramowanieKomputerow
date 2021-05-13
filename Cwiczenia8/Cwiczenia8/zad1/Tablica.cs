using System;
using System.Collections.Generic;
using System.Reflection;

namespace zad1
{
    public class Tablica<T>
    {
        public delegate string Formatuj(T obj);

        private T[] _tab;
        //private PropertyInfo[] arr;

        public Tablica(T[] tab)
        {
            _tab = tab;
            //arr = typeof(T).GetProperties();
        }

        public T this[int index]
        {
            get { return _tab[index];}
            set
            {
                _tab[index] = value;
            }
        }

        public void Wpisz(int index, T parameter)
        {
            if (index<_tab.Length-1)
                _tab[index] = parameter;
            else
            {
                Array.Resize(ref _tab,_tab.Length+1);
                _tab[_tab.Length-1] = parameter;
            }
        }

        public void Wypisz()
        {
            Formatuj FormatujObiekt = obj => obj.ToString();
            foreach (T obj in _tab)
                Console.WriteLine(FormatujObiekt(obj));
        }
        /*public void Wypisz()
        {
            if (_tab[0].GetType().IsPrimitive)
            {
                foreach (T t in _tab)
                    Console.WriteLine(t.ToString());
            }
            else
            {
                // Nagłówek tabeli
                foreach (PropertyInfo w1 in arr)
                    Console.Write($"{w1.Name,-15}");
                Console.WriteLine();
                // Zawartosc tabeli
                foreach (T elem in _tab)
                {
                    if (elem == null)
                        throw new ArgumentException("Obiekt ma wartość null");
                    Console.WriteLine(elem.ToString());
                }
            }
           
        }*/
    }
}
