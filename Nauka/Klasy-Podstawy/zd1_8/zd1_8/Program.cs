using System;

namespace zd1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kalkulator VAT";
            double netto = 0, kwotaVat = 0, brutto;
            int stawkaVat = 0;
            try
            {
                Console.Write("Brutto: ");
                brutto = double.Parse(Console.ReadLine());
                Console.Write("\nStawka VAT (0,5,8 lub 23): ");
                stawkaVat = int.Parse(Console.ReadLine());
                netto = KalkulatorVat.BruttoNaNetto(brutto, stawkaVat, out kwotaVat);
                Console.WriteLine($"Netto {netto:C} Kwota VAT {kwotaVat:C}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadLine();
        }
    }
}