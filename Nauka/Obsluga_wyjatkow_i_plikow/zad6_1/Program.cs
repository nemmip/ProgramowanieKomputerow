using System;
using System.IO;
using System.Reflection;

namespace zad6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zapis do pliku wykazu metod z klasy Math";
            Assembly ass = Assembly.Load("Mscorlib");
            Type typ = ass.GetType("System.Math");
            MethodInfo[] tab = typ.GetMethods();
            string plik = @"..\..\MetodyKlasyMath.txt";
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(plik, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);
                foreach (MethodInfo metoda in tab)
                {
                    sw.WriteLine(metoda.ToString());
                }

                Console.WriteLine("Dane zostały zapisane do pliku");
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
                if(sw!=null)
                    sw.Close();
            }
        }
    }
}