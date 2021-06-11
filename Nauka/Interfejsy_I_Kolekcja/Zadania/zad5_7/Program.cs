using System;
using System.Collections.Generic;

namespace zad5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigura> figury = new List<IFigura>
            {
                new Kolo() {Promien = 5, Color = ConsoleColor.Cyan},
                new Kolo() {Promien = 6.66, Color = ConsoleColor.Red},
                new Prostokat(4, 5) {Color = ConsoleColor.Green},
                new Prostokat(8, 9) {Color = ConsoleColor.DarkMagenta},
                new Prostokat(40,3){Color = ConsoleColor.DarkCyan},
                new Kolo(){Promien = 6.1803,Color = ConsoleColor.DarkBlue}
            };
            WyswietlFigure(figury);
            figury.Sort();
            Console.WriteLine();
            WyswietlFigure(figury);
        }

        static void WyswietlFigure(List<IFigura> figury)
        {
            foreach (IFigura figura in figury)
            {
                Console.BackgroundColor = figura.Color;
                if ((byte) figura.Color > 7)
                    Console.ForegroundColor = ConsoleColor.Black;
                else
                    Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(figura);
            }
        }
    }
}