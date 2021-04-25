using System;

namespace z2_14
{
    public struct ZnakNaKonsoli
    {
        private ConsoleKeyInfo znakUser;
        static int X = 0; //na szerokość
        static int Y = 0;//na wysokość;
        private static char znak = '\u25A0';

       public static void DzialaniaZnak()
        {
            Console.Title = $"Znak na konsoli.";
            Console.CursorVisible = false;
            while (true)
            {
                WypiszZnak();
                Poruszanie();
            }
        }

       static void WypiszZnak()
       {
           Console.BackgroundColor = ConsoleColor.Black;
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.White;
           Console.SetCursorPosition(X,Y);
           Console.Write(znak);
       }

       static void Poruszanie()
       {
           do
           {
               ConsoleKeyInfo klawisz = Console.ReadKey();
               if (klawisz.Key == ConsoleKey.UpArrow)//strzałka w górę
               {
                   Y = (Y >0) ? Y-1 : Console.WindowHeight-1;
                   WypiszZnak();
               }
               else if (klawisz.Key == ConsoleKey.DownArrow) //strzałka w dół
               {
                   Y = (Y < Console.WindowHeight-1) ? Y + 1 : 0;
                   WypiszZnak();
               }
               else if (klawisz.Key == ConsoleKey.RightArrow) //strzałka w prawo
               {
                   X = (X < Console.WindowWidth-1) ? X + 1 : 0;
                   WypiszZnak();
               }
               else if (klawisz.Key == ConsoleKey.LeftArrow) //Strzałka w lewo
               {
                   X = (X > 0) ? X - 1 : Console.WindowWidth - 1;
                   WypiszZnak();
               }
               else if (klawisz.Key == ConsoleKey.Enter || klawisz.Key == ConsoleKey.Escape) //wyjście
                   break;
           } while (true);
       }
       
    }
}