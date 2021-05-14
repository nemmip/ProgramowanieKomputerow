using System;
using System.Collections;
using System.Collections.Generic;

namespace zad4
{
    public class Kolory: IEnumerable<string>
    {
        string[] teksty = null;
        public Kolory(params string[] tabParam)
        {
            teksty = new string[tabParam.Length];
            int indeks = 0;
            foreach (string txt in tabParam)
            {
                teksty[indeks++] = txt;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string s in teksty)
            {
                yield return s;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kolory k = new Kolory("biały", "czerwony", "żółty", "zielony", "czarny", "brązowy");
            foreach (string kolor in k)
            {
                Console.WriteLine(kolor);
            }
            Console.ReadKey();
        }
    }
}