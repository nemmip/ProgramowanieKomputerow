using System;
using System.Collections.Generic;
using System.IO;

namespace zad6_3
{
    public class PiszDoPliku<T>
    {
        private Func<T, String> formatujFunc;

        public PiszDoPliku(Func<T,string> formatujDelegat)
        {
            formatujFunc = formatujDelegat;
        }

        public bool Pisz(List<T> lista, string plik, string naglowek = null)
        {
            bool czyZapisano = true;
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(plik, FileMode.Create, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);
                if (naglowek != null)
                    sw.WriteLine(naglowek);
                foreach (T obj in lista)
                {
                    sw.WriteLine(formatujFunc(obj));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                czyZapisano = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                czyZapisano = false;
            }
            finally
            {
                if(sw!=null)
                    sw.Close();
            }

            return czyZapisano;
        }
    }
}