using System;
using System.Linq;

namespace task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string arrow = "^vv<v";
            //string arrow = "v>>>vv";
            string arrow = "<<<";
            Console.WriteLine(arrows(arrow));
        }

        static int arrows(string s)
        {
            char[] arrowArray = new[] {'^', 'v', '<', '>'};
            int[] arrowCounter = new int [4];
            int indexArrow, sumOfDifferentArrows=0;
            foreach (char c in s)
            {
                indexArrow = Array.IndexOf(arrowArray, c);
                arrowCounter[indexArrow]++; //counting all the arrows
            }
            // find the index of max number of the same arrows
            indexArrow = Array.IndexOf(arrowCounter, arrowCounter.Max());
            // count how many arrows are in different direction
            for (int i = 0; i < arrowCounter.Length; i++)
            {
                if (i!=indexArrow)
                    sumOfDifferentArrows += arrowCounter[i];
            }

            return sumOfDifferentArrows;
        }
    }
}