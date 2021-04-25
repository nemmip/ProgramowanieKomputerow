using System;

namespace zd1_7
{
    static class Konsola
    {

        public static Paczka WprowadzDane()//zwraca obiekt paczka
        {
            Paczka tworzonyObiekt = null;
            bool czyPrawidloweDane = true;
            string rodzajPaczki = "ekonomiczna";
            int nrGabarytu;
            //zapytanie o rodzaj paczki
            Console.WriteLine("Czy przesyłka prioryetowa (T/N): ");
            if (Console.ReadLine().ToUpper() == "T")
                rodzajPaczki = "priorytetowa";
            double[] wymiaryWczytane = new double[3];
            //wprowadzenie wymiarów paczki
            for (int i = 0; i < wymiaryWczytane.Length; i++)
            {
                Console.Write($"Wymiar {i+1}: ");
                double.TryParse(Console.ReadLine(), out wymiaryWczytane[i]);
                if (wymiaryWczytane[i]<=0)
                {
                    czyPrawidloweDane = false;
                    break;
                }
            }

            if (!czyPrawidloweDane||(nrGabarytu=Paczka.NumerGabarytu(wymiaryWczytane))<0)
                Console.WriteLine("Nieprawidłowe wymiary!");
            else
            {
                //wywołanie konstruktora po sprawdzeniu poprawności
                tworzonyObiekt = new Paczka(rodzajPaczki, wymiaryWczytane, nrGabarytu);
            }

            return tworzonyObiekt;
        }
    }
}