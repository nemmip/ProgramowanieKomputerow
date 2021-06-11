namespace zad5_2
{
    public class Towar
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public double Ilosc { get; set; }
        public override string ToString() => $"{Nazwa,15}{Cena,10:C}{Ilosc,8}";
    }
}