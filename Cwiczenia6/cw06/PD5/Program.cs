using System;

namespace PD5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] macierzTrojkat =
            {
                {-2, 7, 0, 4, -1},
                {0, 3, 8, -4, 0},
                {0, 0, -5, 3, 6},
                {0, 0, 0, 1, 2},
                {0, 0, 0, 0, 3}
            };
            int[,] macierzJednostkowa =
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };
            MacierzTrojkatna macierzT = new MacierzTrojkatna(macierzTrojkat);
            MacierzJednostkowa macierzJ = new MacierzJednostkowa(macierzJednostkowa);
            
            Console.WriteLine(macierzT.ToString());
            Console.WriteLine(macierzJ.ToString());

            int[,] macierzDiagonal =
            {
                {2, 0, 0, 0},
                {0, 3, 0, 0},
                {0, 0, -1, 0},
                {0, 0, 0, 5}
            };
            int[,] macierzSkalar =
            {
                {2, 0, 0, 0},
                {0, 2, 0, 0},
                {0, 0, 2, 0},
                {0, 0, 0, 2}
            };
            MacierzDiagonalna macierzD = new MacierzDiagonalna(macierzDiagonal);
            MacierzSkalarna macierzS = new MacierzSkalarna(macierzSkalar);
            Console.WriteLine(macierzD.ToString());
            Console.WriteLine(macierzS.ToString());
        }
    }
}