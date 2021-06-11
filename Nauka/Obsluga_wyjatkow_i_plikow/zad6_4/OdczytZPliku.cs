using System;
using System.Collections.Generic;
using System.IO;

namespace zad6_4
{
    static class OdczytZPliku
    {
        public static List<Metoda> PobierzListeZPlikuCSV(string plik)
        {
            string[] zawartoscPliku = null;
            List<Metoda> lista = new List<Metoda>();
            bool czyStatyczna;
            int ileWersji;
            try
            {
                zawartoscPliku = File.ReadAllLines(plik);
                //pomijamy wiersz nr 0 z nagłówkiem
                for (int i = 1; i < zawartoscPliku.Length; i++)
                {
                    string[] tab = zawartoscPliku[i].Split(';');
                    if (tab.Length != 5)
                        throw new Exception("Nieprawidłowa zawartość pliku!");
                    czyStatyczna = tab[2] == true.ToString();
                    int.TryParse(tab[4], out ileWersji);
                    lista.Add(new Metoda
                    {
                        Nazwa = tab[0],
                        TypDeklaracji = tab[1],
                        CzyStatyczna = czyStatyczna,
                        TypZwracany = tab[3],
                        IleWersji = ileWersji
                    });
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                lista = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                lista = null;
            }

            return lista;
        }
    }
}