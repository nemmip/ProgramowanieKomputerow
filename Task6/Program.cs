using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new[] {3, 1, 2, 4, 3};
            Console.WriteLine(AbsoluteMinimalValue(tab));
        }

        static int AbsoluteMinimalValue(int[] A)
        {
            Stack<int> absolute = new Stack<int>();
            
            int sum1, sum2;
            for (int i = 1; i < A.Length; i++)
            {
                //sum of part 1
                sum1 = Sum(A, 0, i);
                //sum of part2
                sum2 = Sum(A, i, A.Length);
                absolute.Push(Math.Abs(sum1-sum2));
            }

            return absolute.Min();
        }

        static int Sum(int[] A, int range1,int range2)
        {
            int sum = 0;
            for (int i = range1; i < range2; i++)
                sum += A[i];
            return sum;
        }
    }
}