namespace zad5
{
    public abstract class Osoba
    {
        protected string _imie, _nazwisko,_kodPocztowy, _miasto, _ulica;

        protected int _numerDomu, _numerMieszkania;
        public string Imie { get =>_imie;
            private set{}
        }
        public string Nazwisko { get=>_nazwisko; private set{} }
        public string KodPocztowy { get=>_kodPocztowy; private set{} }
        public string Miasto { get=>_miasto; private set{} }
        public string Ulica { get=>_ulica; private set{} }
        public int NumerDomu { get=>_numerDomu; private set{} }
        public int NumerMieszkania { get=>_numerMieszkania; private set{} }

        public override string ToString() => $"{GetType().Name,-10}{_imie,5}{_nazwisko,10}{_kodPocztowy,10}" +
                                             $"{_miasto,15}{_ulica,15}{_numerDomu}/{_numerMieszkania}";

    }
}