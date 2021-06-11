namespace zad5_14
{
    public struct Znaczenie
    {
        public string Polski { get; set; }
        public string Angielski { get; set; }

        public Znaczenie(string polski, string angielski)
        {
            this.Polski = polski;
            this.Angielski = angielski;
        }
    }
}