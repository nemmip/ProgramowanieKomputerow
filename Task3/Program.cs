using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new[] {9, 3, 9, 3, 9, 9};
            Console.WriteLine(aloneNumber(tab));
        }

        static int aloneNumber(int[] A)
        {
            List<int> list = new List<int>();
            foreach (int i in A)
            {
                if (list.Contains(i))
                {
                    list.Remove(i);
                }
                else
                {
                    list.Add(i);
                }
            }

            return list[0];
        }
    }
}