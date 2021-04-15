using System;

namespace Struktury
{
    struct PrzykStruktura
    {
        public int x;// nie wolno dawac domyslnych wartości do struktury
    }
    class Program
    {
        static void Main()
        {
            PrzykStruktura s1;//= new PrzykStruktura(); 
            s1.x = 5;
            PrzykStruktura s2 = s1;
            Console.WriteLine($"wartość x dla obiektu s1 to {s1.x}");
            Console.WriteLine($"wartość x dla obiektu s2 to {s2.x}");
            s1.x = 8;
            Console.WriteLine("------------- Po zmianie ----------");
            Console.WriteLine($"wartość x dla obiektu s1 to {s1.x}");
            Console.WriteLine($"wartość x dla obiektu s2 to {s2.x}");

            Console.ReadKey();
        }
    }
}