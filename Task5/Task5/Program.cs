using System;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new[] {2, 3, 1, 5};
            Console.WriteLine(MissingElement(tab));
        }

        static int MissingElement(int[] A)
        {
            int maxRange = A.Length + 1;
            int element = 0;
            for (int i = 1; i <= maxRange; i++)
            {
                if (!A.Contains(i))
                {
                    element = i;
                    break;
                }
            }
            return element;
        }
    }
}