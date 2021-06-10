using System;
using System.Collections.Generic;

namespace zad3
{
    public class Metoda
    {
        public string Nazwa { get; set; }
        public bool CzyWirtualna { get; set; }
        public bool CzyAbstrakcyjna { get; set; }
        public string TypZwracany { get; set; }
        public string Argumenty { get; set; }
        private int LiczbaArg
        {
            get => Argumenty.Split(',').Length - 1;
        }
        public const string NaglowekCSV = "Nazwa;CzyWirtualna;CzyAbstracyjna;TypZwracany;Argumenty";

        public string ToStringCSV() => $"{Nazwa};{CzyWirtualna};{CzyAbstrakcyjna};{TypZwracany};" +
                                       $"{LiczbaArg}";

        public override string ToString() =>
            $"{Nazwa,-25}{CzyWirtualna,10}{CzyAbstrakcyjna,10}{TypZwracany,50}{LiczbaArg,5}";

        public static int Porownaj(Metoda m1, Metoda m2)
        {
            
            if (m1 == null && m2 == null) return 0;
            else if (m1 == null) return -1;
            else if (m2 == null) return 1;

            if (m1.Nazwa.Equals(m2.Nazwa)) return m1.LiczbaArg.CompareTo(m2.LiczbaArg);
            else
                return m1.Nazwa.CompareTo(m2.Nazwa);
        }
    }
}