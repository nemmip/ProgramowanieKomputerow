using System;

namespace cw06
{
    class PiesRasowy:Pies // nie da się zdefioniować dziedziczenia po kilku klasach, klasamoże dziedziczyć tylko po jednej klasie!
    {
        public void rasa()
        {
            Console.WriteLine("Pies jest rasowy");
        }

        //public void szkolenia() // metoda z klasy potomnej przykryła niejawnie metodę z klasy pochodnej
        
        //public new void szkolenia() //modyfikator new wskazuje że jest to nowa metoda względem metody w klasie bazowej
        //przykryliśmy nową wersją metody metodę bazową
        //operator new działa dobrze dla typów wartościowych, nie działa dla referencyjnych
        
        public override void szkolenia() //nie można nadpisać metody, którą dziedziczymy
        //problemem jest to, ze nie przewidzieliśmy w klasie bazowej faktu, że ta metoda będzie gdzieś indziej nadpisywana
        {
            Console.WriteLine("Pies towarzyszący");
        }
    }
}