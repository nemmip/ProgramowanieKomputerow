using System;

namespace PD2
{
    class Kolo:Figura
    {
        private double _promien;
        public Kolo(double promien) => _promien = promien;
        protected override double Pole() => Math.Round(Math.PI * Math.Pow(_promien, 2),2);
        public override string ToString() => $"Promień koła: {_promien,5}; Pole: {Pole(),5}; Kolor: {_kolor,5}";

    }
}