using System;

namespace zad2
{
    public class Klient:IOsoba
    {
        private string _imie;
        private string _nazwisko;
        private string _miasto;
        private string _ulica;
        private string _numerDomu;
        private static Kryterium _kryterium = Kryterium.nazwisko;

        public Kryterium Kryterium
        {
            get { return _kryterium; }
            set { _kryterium = value; }
        }

        public string NumerDomu
        {
            get { return _numerDomu; }
            set { _numerDomu = value; }
        }

        public string Ulica
        {
            get { return _ulica; }
            set { _ulica = value; }
        }

        public string Miasto
        {
            get { return _miasto; }
            set { _miasto = value; }
        }

        public string Nazwisko
        {
            get { return _nazwisko; }
            set { _nazwisko = value; }
        }

        public string Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }

        public int CompareTo(IOsoba obj)
        {
            switch (_kryterium)
            {
                case Kryterium.imie: return obj == null?1:this._imie.CompareTo(obj.Imie);
                case Kryterium.nazwisko: return obj == null?1:this._nazwisko.CompareTo(obj.Nazwisko);
                case Kryterium.miasto: return obj == null?1:this._miasto.CompareTo(obj.Miasto);
                case Kryterium.ulica: return obj == null?1:this._ulica.CompareTo(obj.Miasto);
                default: throw new Exception();
            }
        }

        public override string ToString() =>
            $"{GetType().Name}\n{Imie}\n{Nazwisko}\n{Miasto}\n{Ulica}\n{NumerDomu}";

    }
}