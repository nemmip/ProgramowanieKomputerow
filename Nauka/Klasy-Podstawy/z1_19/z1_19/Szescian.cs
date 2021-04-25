using System;

namespace z1_19
{
    public class Szescian
    {
        private int _krawedzSzescianu;

        public int KrawedzSzescianu
        {
            get { return _krawedzSzescianu; }
            set { _krawedzSzescianu = value > 0 ? value : throw new ArgumentException("Krawędź musi być większa od 0!"); }
        }

        public int Objetosc() => (int) Math.Pow(_krawedzSzescianu, 3);

        public static bool Matrioszka(Szescian[] tab)
        {
            //posortuj od najmniejszego
            Sortowanie(tab);
            //elementy są posortowane, wiec wystarczy sprawdzic czy kolejny element będzie równy
            for (int i = 0; i < tab.Length-1; i++)
            {
                if (tab[i]._krawedzSzescianu==tab[i+1]._krawedzSzescianu)
                {
                    Console.WriteLine($"Pudełko o krawędzi {tab[i]._krawedzSzescianu} już się nie zmieściło");
                    return false;
                }
            }
            Console.WriteLine("Wszystkie pudełka się zmieściły!");
            return true;
        }

        //sortowanie przez wybieranie
        private static void Sortowanie(Szescian[]tab)
        {
            int min;
            for (int i = 0; i < tab.Length-1; i++)
            {
                min = i;
                for (int j = i+1; j < tab.Length; j++)
                {
                    if (tab[j]._krawedzSzescianu<tab[min]._krawedzSzescianu)
                        min = j;
                    //zamiana elementow
                }
                Zamiana(i,min,tab);
            }
        }
        //zamiana elementow
        private static void Zamiana(int indeks1, int indeks2, Szescian[] tab)
        {
            Szescian key = tab[indeks1];
            tab[indeks1] = tab[indeks2];
            tab[indeks2] = key;
        }
    }
}