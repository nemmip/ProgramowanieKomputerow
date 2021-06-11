using System;
using System.Collections.Generic;
using System.Reflection;

namespace zad6_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zapis do pliku";
            Assembly ass = Assembly.Load("Mscorlib");
            Type typ = ass.GetType("System.Math");
            MethodInfo[] tab = typ.GetMethods();
            string plik = @"..\..\NetodyKlasyMath.txt";
            PiszDoPliku<MethodInfo> obj = new PiszDoPliku<MethodInfo>(x => x.ToString());
            List<MethodInfo> lista = new List<MethodInfo>(tab);
            if(obj.Pisz(lista,plik))
                Console.WriteLine("Dane zostały zapisane do pliku");
        }
    }
}