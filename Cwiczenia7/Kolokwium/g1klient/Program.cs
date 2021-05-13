using System;


namespace ConsoleApp11
{
    public abstract class Klient
    {
        private string imie;
        private string nazwisko;
        protected double wartosc;
        public uint sztuki; // zmienic na readonly i na protected bo po co public
        private double cena;

        public Klient(string imie, string nazwisko, uint sztuki, double cena)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.sztuki = sztuki;
            this.cena = cena;
            this.wartosc = this.cena * this.sztuki;// nie było określonej wartości więc wychodziło 0
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public abstract double Rabat();
        public virtual double doZaplaty()
        {
            return wartosc- Rabat(); // było złe działanie
        }
        public override string ToString()
        {
            return $"{imie} {nazwisko} {doZaplaty()}";
        }
    }
    public class KlientDetOkazjonalny:Klient
    {
        public KlientDetOkazjonalny(string imie, string nazwisko, uint sztuki, double cena) : base (imie,nazwisko,sztuki,cena)
        {

        }
        public override double Rabat()
        {
            return (wartosc * 0.05);
        }
    }
    public class KlientDetStaly:Klient
    {
        private double lata;
        public KlientDetStaly(string imie, string nazwisko, uint sztuki, double cena, int lata) : base (imie,nazwisko,sztuki,cena)
        {

        }
        public override double Rabat()
        {
            return wartosc * Math.Round(lata) / 100;
        }
    }

    public class KlientHurtowy:Klient
    {
        public KlientHurtowy(string imie, string nazwisko, uint sztuki, double cena) : base (imie, nazwisko, sztuki, cena)
        {

        }
        public override double Rabat()
        {
            if (sztuki < 100)
            {
                return (wartosc * 0.05);
            }
            else if (sztuki < 200)
            {
                return (wartosc * 0.1);
            }
            else if (sztuki < 500)
            {
                return (wartosc * 0.2);
            }
            else return (wartosc * 0.3);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Klient[] k1 =
            {
                new KlientDetOkazjonalny("Adam","Kowalski",10,10),
                new KlientDetOkazjonalny("Jan","Nowak",5,12),
                new KlientDetStaly("Adam","Laskowski",20,10,2),
                new KlientDetStaly("Mirosław","Jakiś",3,300,1),
                new KlientHurtowy("Michał","Ten",400,25),
                new KlientHurtowy("Wiktor","Witkowski",5,300)
            };
            foreach (var x in k1)
            {
                Console.WriteLine(x.ToString());
            }
            Console.ReadKey();
        }
    }
}
