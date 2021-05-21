namespace zad3
{
    public class Metoda
    {
        public string Nazwa { get; set; }
        public string TypDeklaracji { get; set; }
        public bool CzyStatyczna { get; set; }
        public string TypZwracany { get; set; }
        public int IleWersji { get; set; }
        public const string NaglowekCSV = "Nazwa;TypDeklaracji;CzyStatyczna;TypZwracany;IleWersji";

        public string ToStringCSV() => $"{Nazwa};{TypDeklaracji};{CzyStatyczna};{TypZwracany};{IleWersji}";
    }
}