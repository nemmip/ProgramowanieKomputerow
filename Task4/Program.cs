using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Frog(5, 1000000000, 2));
        }

        static int Frog(int X, int Y, int D)
        {
            int counter = 0;
            while (X<Y)
            {
                X += D;
                counter++;
            }
            return counter;
        }
    }
}