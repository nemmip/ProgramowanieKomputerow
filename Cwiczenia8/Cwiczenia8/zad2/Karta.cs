namespace zad2
{
    public class Karta
    {
        private kolorKarty _kolorKarty;
        private nazwaKarty _nazwaKarty;
        

        public Karta(kolorKarty kolorKarty, nazwaKarty nazwaKarty)
        {
            _kolorKarty = kolorKarty;
            _nazwaKarty = nazwaKarty;
            
        }

        public override string ToString() => $"{_kolorKarty+" "+_nazwaKarty,5}";

    }
}