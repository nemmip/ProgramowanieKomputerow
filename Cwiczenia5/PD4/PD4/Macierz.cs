using System;

namespace PD4
{
    public class Macierz
    {
        private int[,] macierz;
        
        //konstruktor
        public Macierz(int[,] macierz)
        {
            this.macierz = macierz;
        }

        //operatory
        public static Macierz operator +(Macierz lewa, Macierz prawa)
        {
            //aby dodac macierze to musza byc one takich samych wymiarów
            Macierz macierz;
            if (lewa.macierz.GetLength(0) == prawa.macierz.GetLength(0)
                &&
                lewa.macierz.GetLength(1) == prawa.macierz.GetLength(1))
            {
                macierz = new Macierz(new int[lewa.macierz.GetLength(0), lewa.macierz.GetLength(1)]);
                for (int i = 0; i < lewa.macierz.GetLength(0); i++)
                    for (int j = 0; j < lewa.macierz.GetLength(1); j++)
                        macierz.macierz[i, j] = lewa.macierz[i, j] + prawa.macierz[i, j];
            }
            else
                throw new ArgumentException("Macierze nie są sobie równe!");

            return macierz;
        }

        public static Macierz operator *(Macierz lewa, Macierz prawa)
        {
            // aby pomnożyć macierze musi być tyle samo kolumn w lewej co wierszy w prawej
            Macierz macierz;
            if (lewa.macierz.GetLength(1) == prawa.macierz.GetLength(0))
            {
                macierz = new Macierz(new int[lewa.macierz.GetLength(0), prawa.macierz.GetLength(1)]);
                for (int i = 0; i < macierz.macierz.GetLength(0); i++)
                    for (int j = 0; j < macierz.macierz.GetLength(1); j++)
                        for (int k = 0; k < lewa.macierz.GetLength(1); k++)
                            macierz.macierz[i, j] += lewa.macierz[i, k] * prawa.macierz[k, j];

            }
            else
                throw new ArgumentException("Liczba kolumn lewej macierzy nie " +
                                            "jest równa liczbie wierszy prawej macierzy!");

            return macierz;
        }
        //metody
        public override string ToString()
        {
            string wyjscie = default;
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    wyjscie += $"{macierz[i, j],5}";
                }

                wyjscie += '\n';
            }

            return wyjscie;
        }
    }
}