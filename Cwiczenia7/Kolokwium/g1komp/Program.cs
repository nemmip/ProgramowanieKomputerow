using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komputery
{
    struct Komputer
    {
        // można użyć uinta bo i tak przyjmuje wartości tylko dodatnie
        public int id;
        // możliwe wywalenie programu a nawet jeśli to lepiej zrobić to enumem albo tablicą
        public string rodzaj;
        public int pojemnosc_ssd;
        public int pojemnosc_hdd;
        // brakuje pola na sumę pojemności
        public double cena; 

        public Komputer(int id, string rodzaj, int pojemnosc_ssd, int pojemnosc_hdd, double cena)
        {
            this.id = id;
            this.rodzaj = rodzaj;
            this.pojemnosc_ssd = pojemnosc_ssd;
            this.pojemnosc_hdd = pojemnosc_hdd;
            // brak sumy pojemnosci
            this.cena = cena;
        }

        public static bool operator >(Komputer k1, Komputer k2)
        {
            // czemu tutaj jest tylko hdd?
            if (k1.pojemnosc_hdd > k2.pojemnosc_hdd)
            {
                return true;
            }
            else return false;
        }
        public static bool operator<(Komputer k1, Komputer k2)
        {
            // czemu tutaj jest tylko ssd?
            if (k1.pojemnosc_ssd < k2.pojemnosc_ssd)
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return $"\nID: {id} \nRodzaj: {rodzaj} \nDysk SSD: {pojemnosc_ssd} GB \nDysk HDD: {pojemnosc_hdd} GB \nCena: {cena} zł";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Komputer[] k1 = new Komputer[4];
            k1[0] = new Komputer(123456, "Laptop", 512, 1024, 2600);
            k1[1] = new Komputer(789012, "Stacjonarny", 1024, 2048, 5500);
            k1[2] = new Komputer(364789, "All-in-one", 0, 512, 2000);
            k1[3] = new Komputer(764597, "Tablet", 64, 0, 1000);

            Console.WriteLine("Wybierz rodzaj komputera: ");
            Console.WriteLine("[1] Laptop \n[2] Komputer stacjonarny \n[3] All-in-one \n[4] Tablet");
            int wybierz = int.Parse(Console.ReadLine());
            switch(wybierz)
            {
                case 1:
                    Console.WriteLine(k1[0].ToString());
                    break;
                case 2:
                    Console.WriteLine(k1[1].ToString());
                    break;
                case 3:
                    Console.WriteLine(k1[2].ToString());
                    break;
                case 4:
                    Console.WriteLine(k1[3].ToString());
                    break;
                default: //proba ogarniecia uzytkownika, można było to zrobić w klasie, sprawdzic czy lancuch nalezy do tablicy albo enum
                    Console.WriteLine("Niepoprawne dane wejściowe");
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("HDD jest większy od SSD: " + (k1[0] < k1[1]));
            Console.WriteLine("SSD jest większy od HDD: " + (k1[0] > k1[1]));
            Console.ReadKey();
        }
    }
}
