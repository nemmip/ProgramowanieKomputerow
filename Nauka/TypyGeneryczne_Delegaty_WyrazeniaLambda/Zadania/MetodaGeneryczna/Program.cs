using System;

namespace MetodaGeneryczna
{
    class Program
    {
        static void Swap<T>(ref T x1, ref T x2)
        {
            T temp;
            temp = x1;
            x1 = x2;
            x2 = temp;
        }
        static void Main(string[] args)
        {
            Console.Title = "Metoda Generyczna";
            int x1 = 12, y1 = 24;
            string x2 = "Jeden", y2 = "Dwa";
            Console.WriteLine($"Było: {x1} {y1} oraz {x2} {y2}");
            Swap(ref x1,ref y1);
            Swap(ref x2,ref y2);
            Console.WriteLine($"Jest: {x1} {y1} oraz {x2} {y2}");
        }
    }
}