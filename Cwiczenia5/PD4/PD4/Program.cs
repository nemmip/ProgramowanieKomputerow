using System;

namespace PD4
{
    class Program
    {
        static void Main(string[] args)
        {
            //dodawanie macierzy
            /*int[,] tab1 = new int[,]
            {
                {3, 5, 10}, 
                {1, 2, 15}
            };
            int[,] tab2 = new int[,]
            {
                {2, 5, -2},
                {4, -4, 5}
            };
            Macierz mdod1 = new Macierz(tab1);
            Macierz mdod2 = new Macierz(tab2);
            Console.WriteLine("Dodawanie macierzy");
            Console.WriteLine(mdod1.ToString());
            Console.WriteLine("+");
            Console.WriteLine(mdod2.ToString());
            Console.WriteLine("Wynik:");
            Console.WriteLine((mdod1+mdod2).ToString());*/
            
            // mnożenie macierzy
            int[,] tab3 = new int[,]
            {
                {2, 1, 3}, 
                {-1, 2, 4}
            };
            int[,] tab4 = new int[,]
            {
                {1,3},
                {2,-2},
                {-1,4}
            };
            Console.WriteLine("Mnożenie macierzy");
            Macierz mmno1 = new Macierz(tab3);
            Macierz mmno2 = new Macierz(tab4);
            Console.WriteLine(mmno1.ToString());
            Console.WriteLine("*");
            Console.WriteLine(mmno2.ToString());
            Console.WriteLine("Wynik:");
            Console.WriteLine((mmno1*mmno2).ToString());
        }
    }
}