using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace zad5
{
    public class Towar:IXmlSerializable
    {
        public string NazwaTowaru { get; set; }
        public int Ilosc { get; set; }
        public double Cena { get; set; }
        public double Wartosc { get=>Cena*Ilosc; set{} }
        public XmlSchema? GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            
            NazwaTowaru = reader.ReadContentAsString();
            Ilosc = reader.ReadContentAsInt();
            Cena = reader.ReadContentAsDouble();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Nazwa");
            writer.WriteString(NazwaTowaru);
            writer.WriteEndElement();
            
            writer.WriteStartElement("Ilosc");
            writer.WriteString(Ilosc.ToString());
            writer.WriteEndElement();
            
            writer.WriteStartElement("Cena");
            writer.WriteString(Cena.ToString());
            writer.WriteEndElement();
            
            writer.WriteStartElement("Wartosc");
            writer.WriteString(Wartosc.ToString());
            writer.WriteEndElement();
            
        }
    }
}