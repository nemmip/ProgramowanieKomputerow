using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace zad1
{
    public class Pracownicy
    {
        private List<Pracownik> _listaPracownikow= new List<Pracownik>();
        private string[] _pracownik;
        static PropertyInfo[] header = typeof(Pracownik).GetProperties();

        public void LoadFromCSV(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string line;
            int counter = 0;
            while ((line = streamReader.ReadLine()) != null)
            {
                counter++;
                if (counter != 1)
                {
                    _pracownik = line.Split(';');
                    LoadEmployee();
                }
            }

            streamReader.Close();
            fileStream.Close();
        }

        void LoadEmployee()
        {
            Pracownik pracownik = new Pracownik(_pracownik);
            _listaPracownikow.Add(pracownik);
        }

        public void ShowEmployees()
        {
            foreach (PropertyInfo info in header)
            {
                if (info.PropertyType == typeof(string))
                    Console.Write($"{info.Name,-15}");
                else
                    Console.Write($"{info.Name,10}");
            }

            Console.Write($"{"Pensja",10}\n");
            foreach (Pracownik pracownik in _listaPracownikow)
                Console.WriteLine(pracownik.ToString());
        }

        public void SaveIntoFile(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            string naglowki=String.Empty;
            //załaduj nagłówki
            foreach (PropertyInfo info in header)
                naglowki += info.Name + ';';
            streamWriter.WriteLine("Pensja" + ';');

            //wpisz dane
            foreach (Pracownik pracownik in _listaPracownikow)
            {
                streamWriter.WriteLine(pracownik.Imie + ';' + pracownik.Nazwisko + ';'
                              + pracownik.Godziny.ToString() + ';' + pracownik.Stawka.ToString() + ';' +
                              pracownik.Pensja());
            }

            streamWriter.Close();
            fileStream.Close();
        }
    }
}