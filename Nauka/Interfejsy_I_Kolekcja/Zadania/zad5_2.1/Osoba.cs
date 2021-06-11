namespace zad5_2
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;

        public Osoba(string imie,string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString() => $"{imie} {nazwisko}";
    }
}