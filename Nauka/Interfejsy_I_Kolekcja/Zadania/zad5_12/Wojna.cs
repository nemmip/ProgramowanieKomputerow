using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5_12
{
    public class Wojna<T>:Queue<T> where T:Karty
    {
        private Queue<Karty> g1;
        private Queue<Karty> g2;
        public Wojna(Queue<Karty> g1, Queue<Karty> g2)
        {
            this.g1 = g1;
            this.g2 = g2;
        }

        public void Gra()
        {
            while (g1.Count != 0 && g2.Count != 0)
            {
                Tura();
            }
            Wygrana();
        }

        private void Wygrana()
        {
            int wynik = g1.Count.CompareTo(g2.Count);
            if(wynik == -1) Console.WriteLine("Wygrywa gracz 1");
            else if(wynik==1) Console.WriteLine("Wygrywa gracz 2");
            else if(wynik==0) Console.WriteLine("Remis");
        }

        private void Tura()
        {
            
            Console.WriteLine("G1: "+ g1.Peek().Rewers);
            Console.WriteLine("G2: "+ g2.Peek().Rewers+"\n");
            switch (g1.Peek().CompareTo(g2.Peek()))
            {
                case -1: g1.Enqueue(g2.Dequeue());
                    break;
                case 0:  Remis();
                    break;
                case 1: g2.Enqueue(g1.Dequeue());
                    break;
            }
            
        }

        private void Remis()
        {
            Console.WriteLine("Wojna!");
            Stack<Karty> remisStos = new Stack<Karty>();
            while (g1.Peek().CompareTo(g2.Peek()) == 0)
            {
                remisStos.Push(g1.Dequeue());
                remisStos.Push(g2.Dequeue());
                
                Console.WriteLine("G1: "+ g1.Peek().Rewers);
                Console.WriteLine("G2: "+ g2.Peek().Rewers);

            }

            PrzeniesKarty(remisStos,g1.Peek().CompareTo(g2.Peek()));
        }

        private void PrzeniesKarty(Stack<Karty> stos, int numerGracza)
        {
            if (numerGracza == -1)
            {
                while (stos.Count>0)
                {
                    g1.Enqueue(stos.Pop());
                }
            }
            else if (numerGracza == 1)
            {
                while (stos.Count>0)
                {
                    g2.Enqueue(stos.Pop());
                }
            }
        }

    }
}