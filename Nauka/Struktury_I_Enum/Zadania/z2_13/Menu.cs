using System;

namespace z2_13
{
    static class Menu
    {
        private static string[] pozycjeMenu = {"Planer zadań", "Kula 3D", "Kwartalniki","Koniec"};
        private static int aktywnaPozycja = 0;
        public static void wypiszMenu()
        {
            Console.Title = "MENU";
            Console.CursorVisible = false;
            while (true)
            {
                PokazMenu();
                WybieranieOpcji();
                UruchomOpcje();
            }
        }

        static void PokazMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(">>>Jaki program mam uruchomić?<<<\n");
            for (int i = 0; i < pozycjeMenu.Length; i++)
            {
                if (i==aktywnaPozycja)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0,-35}", pozycjeMenu[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.WriteLine(pozycjeMenu[i]);
            }
        }

        static void WybieranieOpcji()
        {
            do
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.UpArrow)
                {
                    aktywnaPozycja = (aktywnaPozycja > 0) ? aktywnaPozycja-1 : pozycjeMenu.Length - 1;
                    PokazMenu();
                }
                else if (klawisz.Key==ConsoleKey.DownArrow)
                {
                    aktywnaPozycja = (aktywnaPozycja<pozycjeMenu.Length) ? aktywnaPozycja+1:0;
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    aktywnaPozycja = pozycjeMenu.Length - 1;
                    break;
                }
                else if(klawisz.Key==ConsoleKey.Enter)
                    break;
            } while (true);
        }

        static void UruchomOpcje()
        {
            switch (aktywnaPozycja)
            {
                case 0: Console.Clear(); ZadaniaUruchomienie.PlanowanieZadan();
                    break;
                case 1: Console.Clear(); ZadaniaUruchomienie.Kula3D();
                    break;
                case 2: Console.Clear(); ZadaniaUruchomienie.Kwartalniki();
                    break;
                case 3: Environment.Exit(0);
                    break;
            }
        }
        
    }
}