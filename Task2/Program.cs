using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab = new[] {3, 8, 9, 7, 6};
            //int[] tab = new[] {0, 0, 0};
            //int[] tab = new[] {1, 2, 3, 4};
            int[] tab = Array.Empty<int>();
            foreach (int i in tab)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
            foreach (int i in rotateArr(tab,4))
            {
                Console.Write($"{i,3}");
            }
        }

        static int[] rotateArr(int[] A, int K)
        {
            int key = 0, key2=0;
            if (A.Length>0)
            {
                for (int i = 0; i < K; i++)
                {
                    key = A[0];
                    A[0] = A[A.Length - 1];
                    for (int j = 1; j < A.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            key = A[j];
                            A[j] = key2;
                        }
                        else
                        {
                            key2 = A[j];
                            A[j] = key;
                        }
                    }
                }
            }
            return A;
        }
    }
}