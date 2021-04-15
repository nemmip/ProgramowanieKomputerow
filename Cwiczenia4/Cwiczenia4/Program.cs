using System;

namespace Cwiczenia4
{
    class Program
    {
        static void Main(string[] args)
        {
           //zadanie 1
           /*Sprzedaz[] tablicaSprzedazy =
           {
               new Sprzedaz(25.99, 12),
               new Sprzedaz(48.89, 10),
               new Sprzedaz(17.88, 5),
               new Sprzedaz(12.57, 40),
               new Sprzedaz(2.50, 90)
           };
           Agregacja agregacja = new Agregacja(tablicaSprzedazy);
           agregacja.Wyswietl();*/
           
           //zadanie 2
           // ref - argument wejscia - wyjscia
           /*double kwotaVat = 0;
           double sumaVat = 0;
           Sprzedaz s1 = new Sprzedaz(Dodatki.NettoNaBrutto(5, 23, ref kwotaVat),10);
           Console.WriteLine(s1);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT {sumaVat}");
           
           Sprzedaz s2 = new Sprzedaz(Dodatki.NettoNaBrutto(7.5, 23, ref kwotaVat),10);
           Console.WriteLine(s2);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT {sumaVat}");
           
           Sprzedaz s3 = new Sprzedaz(Dodatki.NettoNaBrutto(18.99, 23, ref kwotaVat),10);
           Console.WriteLine(s3);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT {sumaVat}");*/
           
           // out z deklaracją na listę argumentów metody - argument wyjścia
           /*double sumaVat = 0;
           Sprzedaz s1 = new Sprzedaz(Dodatki.NettoNaBrutto(5, 23, out double kwotaVat), 10);
           Console.WriteLine(s1);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT: {sumaVat}");
           
           Sprzedaz s2 = new Sprzedaz(Dodatki.NettoNaBrutto(3, 23, out kwotaVat), 10);
           Console.WriteLine(s2);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT: {sumaVat}");
           
           Sprzedaz s3 = new Sprzedaz(Dodatki.NettoNaBrutto(11, 23, out kwotaVat), 10);
           Console.WriteLine(s3);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT: {sumaVat}");*/
           
           //out i ref
           double sumaVat = 0;
           Sprzedaz s1 = new Sprzedaz(Dodatki.NettoNaBrutto(5, 23, out double kwotaVat, ref sumaVat), 10);
           Console.WriteLine(s1);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT: {sumaVat:F}");
           
           Sprzedaz s2 = new Sprzedaz(Dodatki.NettoNaBrutto(3, 23, out kwotaVat,ref sumaVat), 10);
           Console.WriteLine(s2);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT: {sumaVat:F}");
           
           Sprzedaz s3 = new Sprzedaz(Dodatki.NettoNaBrutto(11, 23, out kwotaVat, ref sumaVat), 10);
           Console.WriteLine(s3);
           Console.WriteLine($"Kwota VAT {kwotaVat}");
           sumaVat += kwotaVat;
           Console.WriteLine($"Suma VAT: {sumaVat:F}");


        }
    }
}