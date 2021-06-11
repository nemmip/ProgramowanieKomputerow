namespace zad6_5
{
    public class Towar
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public double Ilosc { get; set; }

        public Towar(string n1, double c1, double i1)
        {
            Nazwa = n1;
            Cena = c1;
            Ilosc = i1;
        }

        public Towar()
        {
            
        }
    }
}