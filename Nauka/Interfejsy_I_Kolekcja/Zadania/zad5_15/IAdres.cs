namespace zad5_15
{
    public interface IAdres
    {
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public int NumerLokalu { get; set; }
    }
}