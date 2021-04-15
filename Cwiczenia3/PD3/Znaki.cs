using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;

namespace PD3
{
    public class Znaki
    {
        #region Pola

        private int _kolumna, _wiersz;
        private readonly char[] dozwoloneZnaki = {'*', '#', '+'};
        private char _znak;
        public static int Suma;
        private static readonly Random _random = new Random();
        private static int[,] _nagrody = new int[Console.WindowHeight, Console.WindowWidth];

        #endregion
        
        #region Konstruktory

        public Znaki()
        {
            _znak = dozwoloneZnaki[_random.Next(3)];
            _kolumna = _random.Next(Console.WindowWidth);
            _wiersz = _random.Next(Console.WindowHeight);

        }

        public Znaki(int kolumna, int wiersz, char znak)
        {
            _kolumna = kolumna;
            _wiersz = wiersz;
            _znak = znak;
            Suma = Punkty();
        }

        #endregion

        #region Metody

        public void WyswietlPunkty()
        {
            Console.Title = $"Znaki na konsoli - suma punktów: {Znaki.Suma}";
            
            if (_kolumna<Console.WindowWidth && _wiersz<Console.WindowHeight && dozwoloneZnaki.Contains(_znak))
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                //Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(_kolumna,_wiersz);
                if (_nagrody[_wiersz,_kolumna]!=default)
                {
                    Console.Write('X');
                    _nagrody[_wiersz, _kolumna] = 'X';
                }
                else
                {
                    Console.Write(_znak);
                    _nagrody[_wiersz, _kolumna] = _znak;
                }

                Suma = Punkty();
            }
            Thread.Sleep(250);
        }
        private int Punkty()
        {
            switch (_znak)
            {
                case '*': Suma += 10;
                    break;
                case '+': Suma += 5;
                    break;
                case '#': Suma += 2;
                    break;
            }

            return Suma;
        }

        #endregion
        
    }
}