using System;
using System.IO;
using System.Xml.Serialization;

namespace zad5
{
    public class ZapisOdczytXML
    {
        public static void Zapisz<Typ>(string plik, Typ obj)
        {
            if (string.IsNullOrEmpty(plik))
                throw new ArgumentException(nameof(plik));
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            XmlSerializer xSer = new XmlSerializer(typeof(Typ));
            using (var fs = new FileStream(plik, FileMode.Create))
            {
                xSer.Serialize(fs,obj);
            }
        }

        public static Typ Pobierz<Typ>(string plik)
        {
            if (string.IsNullOrEmpty(plik))
                throw new ArgumentNullException(nameof(plik));
            var xSer = new XmlSerializer(typeof(Typ));
            using (var fs=new FileStream(plik,FileMode.Open))
            {
                return (Typ) xSer.Deserialize(fs);
            }
        }
    }
}