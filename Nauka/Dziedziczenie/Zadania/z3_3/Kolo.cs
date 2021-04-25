using System;

namespace z3_3
{
    class Kolo
    {
        private double promien;//promien koła
        public Kolo(double promien) => this.promien = promien;
        protected double Pole() => Math.PI * Math.Pow(promien, 2);
        public override string ToString() => $"{GetType().Name,-12} {promien,4} cm {Pole(),10:F2} cm^2";
        public override bool Equals(object obj) //sprawdza czy dwa kola maja ten sam promien
        {
            if ((obj == null) || GetType() != obj.GetType())
                return false;
            Kolo k1 = (Kolo) obj;// taki zapis nigdy nie zglosi wyjatki, użycie as pozwala na to
            return (promien == k1.promien);
        }
    }
}