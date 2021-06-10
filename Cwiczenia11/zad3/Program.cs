using System;
using System.Collections.Generic;
using System.Reflection;

namespace zad3
{
    class Program
    {
        public delegate string Dodaj(ParameterInfo[] tab);
    
        static void Main(string[] args)
        {
            
            
            Assembly ass = Assembly.Load("Mscorlib");
            Type typ = ass.GetType("System.IO.Stream");
            MethodInfo[] tab = typ.GetMethods();
            var lista = PobierzMetody(tab);
            string plik = @"..\..\MetodyKlasyMath.csv";
            PiszDoPliku<Metoda> obj =
                new PiszDoPliku<Metoda>(x => x.ToStringCSV());
            if (obj.Pisz(lista, plik, Metoda.NaglowekCSV))
                Console.WriteLine("Dane zostały zapisane do pliku");
            
            lista.Sort(Metoda.Porownaj);
            
            foreach (Metoda metoda in lista)
            {
                Console.WriteLine(metoda.ToString());
            }
            Console.ReadKey();
        }

        static List<Metoda> PobierzMetody(MethodInfo[] tab)
        {
            List<Metoda> lista = new List<Metoda>();
            Dodaj del = infos => {
                string output = String.Empty;
                foreach (ParameterInfo parameter in infos)
                    output += parameter.Name.ToString() + ',';
                return output;
            };  
            
            foreach (MethodInfo m1 in tab)
            {
                lista.Add(new Metoda
                {
                    Nazwa = m1.Name,
                    CzyAbstrakcyjna = m1.IsAbstract,
                    CzyWirtualna = m1.IsVirtual,
                    TypZwracany = m1.ReturnType.ToString(),
                    Argumenty = del(m1.GetParameters())
                });
            }

            return lista;
        }
    }
}