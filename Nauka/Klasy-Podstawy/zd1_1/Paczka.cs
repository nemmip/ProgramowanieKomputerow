using System;

namespace zd1_1
{
    public class Paczka
    {
        //Zadanie1
        #region Pola
        //zadanie 6 pole statyczne
        public static int _liczbaPaczek;
        //komentarz na potrzeby zadania 4
        private string _rodzajPaczki;
        private double _dlugosc, _szerokosc, _wysokosc;
        private double _objetosc;
        
        #endregion
        
        #region Właściwości
        //zadanie 4
        /*public string rodzajPaczki  
        {
            get { return _rodzajPaczki; }
            set { _rodzajPaczki = value; }
        }*/
        //zadanie 5 - automatyczne właściwości
        /*public string _rodzajPaczki { get; set; }
        public double _dlugosc { get; set; }
        public double _szerokosc { get; set; }
        public double _wysokosc { get; set; }

        public double _objetosc { get; set; }*/
        
        #endregion
        //zadanie1
        #region Konstruktory
        //komentarz jako zadanie 3
        public Paczka(string rodzajPaczki, double dlugosc, double szerokosc, double wysokosc)
        {
            _rodzajPaczki = rodzajPaczki;
            _dlugosc = dlugosc;
            _szerokosc = szerokosc;
            _wysokosc = wysokosc;
            _objetosc = _dlugosc * _szerokosc * _wysokosc;
            _liczbaPaczek++;
        }
        //zadanie 6
        static Paczka()//konstruktor statyczny
        {
            _liczbaPaczek = 0;
        }

        public Paczka(Paczka kopia) //konstruktor kopiujący
        {
            _rodzajPaczki = kopia._rodzajPaczki;
            _dlugosc = kopia._dlugosc;
            _szerokosc = kopia._szerokosc;
            _wysokosc = kopia._wysokosc;
            _objetosc = kopia._objetosc;
            _liczbaPaczek++;

        }
        #endregion
        //Zadanie1
        #region Metody

        public override string ToString()
        {
            return $"{_rodzajPaczki,-15} długość:{_dlugosc,8}cm, szerokość:{_szerokosc,8}cm, wysokość:{_wysokosc,8}cm," +
                   $"objętość:{_objetosc,10}cm^3";
        }

        public void Wyswietl()
        {
            Console.WriteLine(ToString());
        }
        //Zadanie 3
        public static double MaxObjetosc(Paczka[] tablica)
        {
            double max = -1;
            foreach (Paczka paczka in tablica)
            {
                if (max<paczka._objetosc)
                {
                    max = paczka._objetosc;
                }
            }

            return max;
        }
        #endregion
    }
}