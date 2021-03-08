using System;

namespace Wlasciwosci
{
    class Wlasciwosci
    {
        private string _imie;

        // set na private nie pozwala na ustwaienie właściwości poza klasą
        public string Imie { get; private set; }
        public string Nazwisko { get; set; }
        //private string _imieNazwisko;

        // public string ImieNazwisko
        // {
        //    // get { return $"{Imie} {Nazwisko}"; }
        //    // uproszczenie zapisu:
        //    get => $"{Imie} {Nazwisko}"
        // }
        //jeszcze większe uproszczenie
        public string ImieNazwisko => $"{Imie} {Nazwisko}";
        private int _wiek;

        public int Wiek
        {
            set { _wiek = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wlasciwosci m1 = new Wlasciwosci()
            {
                //Imie = "Jan",
                Nazwisko = "Pik",
                Wiek = 23
            };
            Console.WriteLine($"Nasz pracownik to {m1.ImieNazwisko}");
            //Console.WriteLine($"A jego wiek to {m1.Wiek}");
            Console.ReadLine();
        }
    }
}