using System;
using System.Collections.Generic;
using System.Reflection;

namespace zad5_15
{
    public class Osoby<IOsoba>:List<IOsoba>
    {
        private static string kreski = String.Empty.PadLeft(30,'-');
        public static void StworzNaklejke(IOsoba osoba)
        {
            IEnumerable<PropertyInfo> wlasciwosci = osoba.GetType().GetProperties();
            Console.WriteLine(kreski);
            foreach (PropertyInfo info in wlasciwosci)
            {
                Console.WriteLine($"|{info.Name+':',-15} {info.GetValue(osoba),10}|");
            }
            Console.WriteLine(kreski);
        }
    }
}