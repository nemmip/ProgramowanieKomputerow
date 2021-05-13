using System;

namespace task1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int[] ArrayToZero(int N)
        {
            Random random = new Random();
            int[] array = new int[N];
            array[0] = random.Next(N); //some random number
            int sum = array[0]
            for (int i = 1; i < N; i++)
            {
                if (sum>0)
                {
                    array[i] = random.Next(-sum, 1);
                    sum += array[i];
                }
                else
                {
                    array[i] = random.Next(0, -sum);
                    sum += array[i];
                }
            }

            return array;
        }
    }
}