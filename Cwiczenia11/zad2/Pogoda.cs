using System;
using System.Collections.Generic;
using System.IO;

namespace zad2
{
    public class Pogoda
    {
        private static double _addedHours = 0;
        private DateTime _czasPomiaru = DateTime.Now;
        private double _temperatura;
        private double _predkoscWiatru;
        private KierunekWiatru _kierunekWiatru;
        private double _wilgotnoscPowietrza;
        private Zachmurzenie _zachmurzenie;

        private Random _random = new Random();

        private Pogoda()
        {
            _czasPomiaru=_czasPomiaru.AddHours(_addedHours);
            _addedHours++;
            _temperatura = _random.Next(-88, 59);
            _predkoscWiatru = _random.Next(405);
            _kierunekWiatru = (KierunekWiatru)_random.Next(4);
            _wilgotnoscPowietrza = Math.Round(_random.NextDouble(),4);
            _zachmurzenie = (Zachmurzenie) _random.Next(4);

        }

        private Pogoda(string[] tab)
        {
            if (tab.Length == 6)
            {
                _czasPomiaru = DateTime.Parse(tab[0]);
                _temperatura = double.Parse(tab[1]);
                _predkoscWiatru = double.Parse(tab[2]);
                KierunekWiatru.TryParse(tab[3], out _kierunekWiatru);
                _wilgotnoscPowietrza = double.Parse(tab[4]);
                Zachmurzenie.TryParse(tab[5], out _zachmurzenie);
            }
        }

        public static List<Pogoda> GeneratorObiektow(int liczbaObiektow)
        {
            List<Pogoda> _listaObiektow = new List<Pogoda>();   
            for (int i = 0; i < liczbaObiektow; i++)
                _listaObiektow.Add(new Pogoda());

            return _listaObiektow;
        }

        public static void LoadFromCSV(List<Pogoda> _listaObiektow, string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string line;
            string[] obj;
            int lineCounter = 0;

            while ((line=streamReader.ReadLine())!=null)
            {
                if (lineCounter != 0)
                {
                    obj = line.Split(';');
                    _listaObiektow.Add(new Pogoda(obj));
                }

                lineCounter++;
            }
            
            streamReader.Close();
            fileStream.Close();
        }

        public override string ToString() => $"{_czasPomiaru,-15}{_temperatura,13}{_predkoscWiatru,24}" +
                                             $"{_kierunekWiatru.ToString(),27}{_wilgotnoscPowietrza,22:P}" +
                                             $"{_zachmurzenie.ToString(),25}";

        public static void Summary(List<Pogoda> _listaObiektow)
        {
            int brakChmurCount = 0, wilgotnosc80 = 0;
            Console.WriteLine($"{"Czas pomiaru",-10}{"Temperatura",25}{"Predkość wiatru",25}" +
                              $"{"Kierunek wiatru",25}{"Wilgotnosc powietrza",25}{"Zachmurzenie",20}");
            foreach (Pogoda pogoda in _listaObiektow)
            {
                Console.WriteLine(pogoda.ToString());
                if (pogoda._zachmurzenie == Zachmurzenie.brak)
                    brakChmurCount++;
                if (pogoda._wilgotnoscPowietrza > 0.8)
                    wilgotnosc80++;
            }
            Console.WriteLine($"Pomiary z brakiem chmur: {brakChmurCount}");
            Console.WriteLine($"Pomiary z wilgotnością powyżej 80%: {wilgotnosc80}");
        }

        public static void SaveIntoCSV(List<Pogoda> _listaObiektow, string path)
        {
            File.WriteAllText(path,string.Empty);
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            
            streamWriter.WriteLine("CzasPomiaru;Temperatura;PrędkoscWiatru;" +
                                   "KierunekWiatru;WilgotnoscPowietrza;Zachmurzenie");
            foreach (Pogoda pogoda in _listaObiektow)
            {
                streamWriter.WriteLine($"{pogoda._czasPomiaru};{pogoda._temperatura};{pogoda._predkoscWiatru};" +
                                       $"{pogoda._kierunekWiatru.ToString()};{pogoda._wilgotnoscPowietrza};" +
                                       $"{pogoda._zachmurzenie.ToString()}");
            }
            streamWriter.Close();
            fileStream.Close();
        }

    }
}