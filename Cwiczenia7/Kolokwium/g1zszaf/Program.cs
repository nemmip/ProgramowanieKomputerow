using System;
using System.Threading;


namespace Szafa_jeszcze_raz
{
    public abstract class Szafa
    {
        // pola z odpowiednim dostępem, tutaj lepszy protected
        public double wysokosc;
        public double szerokosc;
        public double glebokosc; 

        // jest okej, ale brakuje sprawdzenia czy wymiary są prawidłowe
        public Szafa(double a, double b, double c)
        {
            wysokosc = a;
            szerokosc = b;
            glebokosc = c;
        }
        //to jest dobrze
        public abstract double Cena(); 
        //brakuje ToString, przez co powiela się kod
        protected void zleWartosci()
        {
            if (wysokosc==0 && szerokosc==0 && glebokosc==0)
            {
                Console.WriteLine("Niepoprawne dane wejściowe!");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else
            {

            }
        }

    }
    public class SzafaWolnostojaca:Szafa
    {
        //brak pól przez co metoda cena jest taka rozbudowana
        public SzafaWolnostojaca(double a, double b, double c) : base(a, b, c)
        {
            //okej, ale można było przypisać dodatkowe pola w celu przejrzystości kodu
            
        }
        public override double Cena()// bardzo długa metoda
        {
            return 2 * (wysokosc * szerokosc * 100) + 2 * (wysokosc * glebokosc * 30) + (szerokosc * glebokosc * 40) + (szerokosc * glebokosc); 
        }
        public override string ToString()// można było to skrócić przez dziedziczenie metody z szafy
        {
            return $"Szafa wolnostojąca Wysokość: {wysokosc} Szerokość: {szerokosc} Głębokość: {glebokosc} Cena: {Cena()}";
        }
    }
    public class SzafaWnekowa:Szafa
    {
        public SzafaWnekowa(double a, double b, double c) : base(a, b, c)
        {
            // to samo co poprzednio
        }
        public override double Cena()// nie ma zbyt dużego znaczenia tutaj ale dalej ta sama sytuacja
        {
            return (wysokosc * szerokosc * 100) + (szerokosc * glebokosc * 20);
        }
        public override string ToString()// to samo co poprzednio
        {
            return $"Szafa wnękowa Wysokość: {wysokosc} Szerokość: {szerokosc} Głębokość: {glebokosc} Cena: {Cena()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szafa[] szafy = new Szafa[2];
            szafy[0] = new SzafaWolnostojaca(20, 10, 5);
            szafy[1] = new SzafaWnekowa(4, 2, 5);

            foreach(var x in szafy)
            {
                Console.WriteLine(x.ToString());
            }

            Console.ReadKey();
        }
    }
}