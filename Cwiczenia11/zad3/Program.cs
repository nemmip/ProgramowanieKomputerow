using System;
using System.Collections.Generic;
using System.Reflection;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly ass = Assembly.Load("Mscorlib.dll");
            Type typ = ass.GetType("System.IO.Stream");
            MethodInfo[] tab = typ.GetMethods();
            var lista = PobierzMetody(tab);
            string plik = @"C:\test\MetodyKlasyMath.csv";
            PiszDoPliku<Metoda> obj =
                new PiszDoPliku<Metoda>(x => x.ToStringCSV());
            if (obj.Pisz(lista, plik, Metoda.NaglowekCSV))
                Console.WriteLine("Dane zostały zapisane do pliku");
            Console.ReadKey();
        }

        static List<Metoda> PobierzMetody(MethodInfo[] tab)
        {
            List<Metoda> lista = new List<Metoda>();
            int indeks;
            foreach (MethodInfo m1 in tab)
            {
                if ((indeks = lista.FindIndex(i => i.Nazwa == m1.Name)) >= 0)
                {
                    //Ta metoda jest już na liście
                    lista[indeks].IleWersji++;
                }
                else
                {
                    lista.Add(new Metoda
                    {
                       Nazwa = m1.Name,
                       TypDeklaracji = m1.DeclaringType.ToString(),
                       CzyStatyczna = m1.IsStatic,
                       TypZwracany = m1.ReturnType.ToString(),
                       IleWersji = 1
                    });
                }
            }

            return lista;
        }
    }
}