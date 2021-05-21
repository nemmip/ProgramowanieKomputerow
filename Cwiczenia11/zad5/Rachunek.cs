using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace zad5
{
    [XmlRoot("Rachunki")]
    public class Rachunek
    {
        public string NumerRachunku { get; set; }
        public DateTime DataZakupu { get; set; }
        [XmlArray("listaTowarow"),XmlArrayItem("Towar")]
        public List<Towar> PozycjaRachunku { get; set; }

        public Rachunek(){}
    
    }
}