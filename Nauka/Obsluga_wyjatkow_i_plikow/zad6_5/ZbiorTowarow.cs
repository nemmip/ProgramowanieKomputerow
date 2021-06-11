using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace zad6_5
{
    [XmlRoot("KolekcjaTowarow")]
    public class ZbiorTowarow
    {
        [XmlArray("Towary"), XmlArrayItem("Towar")]
        public List<Towar> listaTowarow = null;

        public ZbiorTowarow(Towar[]tab)
        {
            listaTowarow = new List<Towar>(tab);
        }
        //konstruktor domyślny konieczny dla serializacji
        public ZbiorTowarow()
        {
            
        }
    }
}