using System;

namespace gzmleko
{
    public struct Mleko
    {
        private double _objetoscButelki;
        private double _zawartoscTluszczu;
        private double _cena;
       public static Kryterium _kryterium =Kryterium.cena;

       public Mleko(double objetoscButelki, double zawartoscTluszczu, double cena)
       {
           _objetoscButelki = objetoscButelki;
           _zawartoscTluszczu = zawartoscTluszczu;
           _cena = cena;
       }

       public static void ZmienKryterium(Kryterium kryterium) => _kryterium = kryterium;

       public override string ToString() =>
           $"Obiekt {GetType().Name}: {_objetoscButelki}l, {_zawartoscTluszczu}% tłuszczu" +
           $" {_cena}zł";

       public static bool operator <(Mleko m1, Mleko m2)
       {
           switch (_kryterium)
           {
               case Kryterium.cena: return m1._cena < m2._cena ? true : false;
               case Kryterium.objetosc: return m1._objetoscButelki < m2._objetoscButelki ? true : false;
               case Kryterium.iloscTluszczu: return m1._zawartoscTluszczu < m2._zawartoscTluszczu ? true : false;
               default: throw new Exception("Błąd!");
           }
       }

       public static bool operator >(Mleko m1, Mleko m2)
       {
           switch (_kryterium)
           {
               case Kryterium.cena: return m1._cena > m2._cena ? true : false;
               case Kryterium.objetosc: return m1._objetoscButelki > m2._objetoscButelki ? true : false;
               case Kryterium.iloscTluszczu: return m1._zawartoscTluszczu > m2._zawartoscTluszczu ? true : false;
               default: throw new Exception("Błąd!");
           }
       }

    }
}