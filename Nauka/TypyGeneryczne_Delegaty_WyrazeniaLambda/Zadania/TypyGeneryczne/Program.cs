using System;

namespace TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Typ generyczny";
            //obiekt typu string 
            KlasaGeneryczna<string> oStr = new KlasaGeneryczna<string>("Pole");
            oStr.wlasciwosc = "Właściwość";
            oStr.generycznaMetoda("Argument");
            //obiekt typu int
            KlasaGeneryczna<int> oInt = new KlasaGeneryczna<int>(200);
            oInt.wlasciwosc = 300;
            oInt.generycznaMetoda(100);
            
        }
    }
}