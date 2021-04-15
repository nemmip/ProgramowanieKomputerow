using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 wersja bez obsługi wyjątków
            /*Console.WriteLine("Wprowadź liczbę");
            int liczba1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wprowadź inną liczbę");
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Wynik dzielenia liczb:{liczba1 / liczba2}");*/
            
            // 2 wersja TryParse
            /*Console.WriteLine("Wprowadź liczbę");
            int.TryParse(Console.ReadLine(), out int liczba1);
            Console.WriteLine("Wprowadź inną liczbę");
            int.TryParse(Console.ReadLine(), out int liczba2);
            Console.WriteLine($"Wynik dzielenia liczb:{liczba1 / liczba2}");*/

            // 3 wersja try catch 
            /*int liczba1, liczba2;
            Console.WriteLine("Wprowadź liczbę");
            try
            {
                liczba1 = Convert.ToInt32(Console.ReadLine());
                if (liczba1 == 10)
                    throw new ArgumentException("Pierwsza liczba nie może być równa 10!");
                
                Console.WriteLine("Wprowadź inną liczbę");
                liczba2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wprowadzono nieprawidłowy typ zmiennej!");
                Console.WriteLine(e.Message);
                throw;
            }

            try
            {
                Console.WriteLine($"Wynik dzielenia liczb:{liczba1 / liczba2}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Dzielenie przez zero!");
                Console.WriteLine(e.Message);
                throw;
            }*/
            int? liczba1 = null;
            int? liczba2 = null;
            int wynik;
            string dane1, dane2;
            // 1 liczba
            do
            {
                Console.WriteLine("Wprowadź pierwszą liczbę: ");
                dane1 = Console.ReadLine();
                try
                {
                    liczba1 = Convert.ToInt32(dane1);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Błąd liczby pierwszej");
                    Console.WriteLine(e.Message);
                    throw;
                }

            } while (liczba1==null);
            do
            {
                Console.WriteLine("Wprowadź drugą liczbę: ");
                dane2 = Console.ReadLine();
                try
                {
                    liczba2 = Convert.ToInt32(dane1);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Błąd liczby drugiej");
                    Console.WriteLine(e.Message);
                    throw;
                }

            } while (liczba2==null);
            try
            {
                Console.WriteLine($"Wynik dzielenia liczb:{liczba1/liczba2}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Dzielenie przez zero!");
                Console.WriteLine(e.Message);
                throw;
            }
            

            static int Dzielenie(int a, int b)
            {
                if (a == 10)
                    throw new Exception("Użyłeś liczby Sam-Wiesz-Jakiej");
                return a / b;
            }

            int x2 = 100;
        }
    }
}