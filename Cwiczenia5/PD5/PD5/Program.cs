using System;

namespace PD5
{
    class Program
    {
        static void Main(string[] args)
        {
            Czas t1 = new Czas(23,30);
            Czas t2 = new Czas(1,0);
            Console.WriteLine(t1 + t2); // 0:30
            Console.WriteLine(t1 - t2); // 22:30
        }
    }
}