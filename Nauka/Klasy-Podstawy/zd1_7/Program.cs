using System;

namespace zd1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Paczka";
            Paczka p1 = Konsola.WprowadzDane();
            if (p1!=null)
                Console.WriteLine(p1.ToString());
            Console.ReadLine();

        }
    }
}