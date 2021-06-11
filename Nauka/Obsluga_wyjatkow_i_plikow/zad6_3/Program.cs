using System;
using System.Collections.Generic;
using System.Reflection;

namespace zad6_3
{
    class Program
    {
        static List<Metoda> PobierzMetody(MethodInfo[] tab)
        {
            List<Metoda> lista = new List<Metoda>();
            int indeks;
            foreach (MethodInfo m1 in tab)
            {
                if ((indeks = lista.FindIndex(i => i.Nazwa == m1.Name)) >= 0)
                {
                    //ta metoda jest już na liscie
                    lista[indeks].IleWersji++;
                }
                else
                {
                    lista.Add(new Metoda
                    {
                        Nazwa=m1.Name,
                        TypDeklaracji = m1.DeclaringType.ToString(),
                        CzyStatyczna = m1.IsStatic,
                        TypZwracany = m1.ReturnType.ToString(),
                        IleWersji = 1
                    });
                }
            }

            return lista;
        }
        static void Main(string[] args)
        {
            Console.Title = "Zapis do pliku CSV";
            Assembly ass = Assembly.Load("Mscorlib");
            Type typ = ass.GetType("System.Math");
            MethodInfo[] tab = typ.GetMethods();
            var lista = PobierzMetody(tab);
            string plik = @"..\..\MetodyKlasyMath.csv";
            PiszDoPliku<Metoda> obj = new PiszDoPliku<Metoda>(x => x.ToStringCSV());
            if(obj.Pisz(lista,plik,Metoda.NaglowekCSV))
                Console.WriteLine("Dane zostały zapisane do pliku");
        }
    }
}