using System;
using System.Collections.Generic;
using System.IO;

namespace zad6_2
{
    public class AnalizaZnakow
    {
        private string plik;
        private List<Znak> lista = null;
        private const int LiczbaZnakow = 400;
        private const int Wyrownanie = 15;

        public AnalizaZnakow(string plik)
        {
            this.plik = plik;
            lista = new List<Znak>();
            for (int i = 0; i < LiczbaZnakow; i++)
            {
                lista.Add(new Znak{KodZnaku = i,Czestosc = 0});
            }
        }

        public void WypiszListeZnakow()
        {
            lista.Sort((a,b)=>(b.Czestosc.CompareTo(a.Czestosc)));
            Console.WriteLine($"{"Kod dziesiętny",Wyrownanie}"+
                              $"{"Znak",Wyrownanie}"+
                              $"{"Częstość",Wyrownanie}");
            foreach (Znak zn in lista)
            {
                if(zn.Czestosc>0)
                    Console.WriteLine($"{zn.KodZnaku,Wyrownanie}"+
                                      $"{(char)zn.KodZnaku,Wyrownanie}"+
                                      $"{zn.Czestosc,Wyrownanie}");
            }
        }

        public void WykonajAnalize()
        {
            FileStream fs = null;
            StreamReader re = null;
            try
            {
                fs = new FileStream(plik, FileMode.Open, FileAccess.Read);
                re = new StreamReader(fs);
                int znak;
                while ((znak = re.Read()) > 0)
                {
                    if (!char.IsControl((char) znak) &&
                        znak < LiczbaZnakow)
                        lista[znak].Czestosc++;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(re!=null)
                    re.Close();
            }
        }
        
    }
}