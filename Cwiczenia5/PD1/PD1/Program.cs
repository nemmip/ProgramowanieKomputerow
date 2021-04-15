using System;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamki u1 = new Ulamki(2,5);
            Ulamki u2 = new Ulamki(1, 10);
            Ulamki wynik = 5* u1 ;
            Console.WriteLine(u1.ToString()+'+'+u2.ToString()+'='+wynik);
            
        }
    }
}