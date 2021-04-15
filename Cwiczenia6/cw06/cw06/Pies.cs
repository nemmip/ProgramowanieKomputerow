using System;

namespace cw06
{
    class Pies:Zwierz
    {
        //public void szczekaj()
        public override void glos()
        {
            Console.WriteLine("Hau,hau");
        }

        public void rysuj()
        {
            Console.WriteLine(" /^ ^\\\n" +
                              "/ 0 0 \\\n" +
                              "V\\ Y /V\n" +
                              " / - \\\n" +
                              " |    \\\n" +
                              " || (__V\n");
        }

        //public void szkolenia()// nie ma oznaczenia, że może być nadpisywana (nie mylić z przykryciem)
        //można zastosować dwa rozwiązania abstract lub virtual
        //abstract przy klasach abstrakcyjnych
        //virtual przy innych, tutaj lepszy virtual
        public virtual void szkolenia() //pozwala na zasygnalizowanie, że ta metoda będzie nadpisywana, a nie przykrywana
        //przez co mozna ją zastosować przy typach referencyjnych
        {
            Console.WriteLine("brak");
        }
    }
}