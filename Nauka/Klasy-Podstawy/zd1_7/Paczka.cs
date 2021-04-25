using System;

namespace zd1_7
{
    class Paczka
    {
        private string _rodzajPaczki;
        //private double _wymiar1, _wymiar2, _wymiar3;
        //zmiana na tablicę double
        private double[] _wymiary = new double[3];
        private char _gabaryt;
        //dopisanie ceny
        private double _cena;
        //dopisanie max gabarytów
        private static readonly double[,] _maxWymiary =
            {{8, 38, 64}, {19, 38, 64}, {38, 41, 64}};
        //dopisanie ceny bazowej
        private static readonly double[] _cenaBazowa = {11.5, 14.25, 16};

        public Paczka(string rodzajPaczki, double[] wymiary,int nrGabarytu)
        {
            _rodzajPaczki = rodzajPaczki;
            Array.Copy(wymiary,_wymiary,wymiary.Length);
            /*bool dwaWymiary = _wymiar2 <= 38 && _wymiar3 <= 64;
            if (dwaWymiary)
            {
                if (_wymiar1 <= 8)
                    _gabaryt = 'A';
                else if (_wymiar1 <= 19)
                    _gabaryt = 'B';
                else if (_wymiar1 <= 41)
                    _gabaryt = 'C';
                else
                    _gabaryt = 'X';
            }
            else
                _gabaryt = 'X';*/
            _gabaryt = Gabaryt(nrGabarytu);
            _cena = ObliczCene(nrGabarytu);
        }

        double ObliczCene(int nrGabarytu)
        {
            /*double cena = default;
            if (_rodzajPaczki.ToLower()=="ekonomiczna" || _rodzajPaczki.ToLower()=="priorytetowa")
            {
                if (_rodzajPaczki.ToLower() == "priorytetowa")
                    cena += 2;
                
                switch (_gabaryt)
                {
                    case 'A': cena += 11.50;
                        break;
                    case 'B': cena += 14.25;
                        break;
                    case 'C': cena += 16;
                        break;
                    default: cena = -1;
                        break;
                }
                return cena;
            }
            else
            {
                return -1;
            }*/
            return _cenaBazowa[nrGabarytu] + (_rodzajPaczki.ToLower() == "priorytetowa" ? 2 : 0);

        }
        //metoda na okreslenie gabarytu
        public static int NumerGabarytu(double[] wymiary)
        {
            Array.Sort(wymiary);
            int nrGabarytu = 0;
            for (int i = 0; i < _maxWymiary.GetLength(0); i++)//pętla dla wierszy
            {
                nrGabarytu = i;
                for (int j = 0; j < _maxWymiary.GetLength(1); j++) //dla poszczegolnych wymiarow
                {
                    if (wymiary[j]>_maxWymiary[i,j])
                    {
                        nrGabarytu = -1;
                        break;
                    }
                }

                if (nrGabarytu>=0)
                    break; //ustalony gabaryt
            }

            return nrGabarytu;
        }

        private char Gabaryt(int nrGabarytu)
        {
            return (char) (65 + nrGabarytu);
        }

        public override string ToString()
        {
            /*if (_gabaryt!='X' && Cena()!=-1)
            {
                return $"Gabaryt: {_gabaryt}; Cena: {Cena():C}";
            }
            else if (_gabaryt=='X')
            {
                return "Nieprawidłowy wymiar paczki!";
            }
            else if (Cena()==-1)
            {
                return "Nieprawidłowy rodzaj paczki!";
            }
            else
            {
                return $"Wystąpił błąd!";
            }*/
            return $"{_rodzajPaczki,-15} {_wymiary[0],8}" +
                   $" {_wymiary[1],8} {_wymiary[2],8} " +
                   $"{_gabaryt,8} {_cena,8}zł";
        }
    }
}