using System;

namespace zad1
{
    public class Kolo:IFigura
    {
        private double _promien;
        private ConsoleColor _kolor;
        public ConsoleColor Kolor { get=>_kolor; set=>_kolor=value; }
        public Kolo(double promien) => _promien = promien;

        public double Pole()=>Math.Round((Math.PI * Math.Pow(_promien, 2)),2);

        public override string ToString() => $"Promien {_promien,10}; Pole: {Pole()+";",-25}";

        public int CompareTo(IFigura obj) => obj == null ? 1 : Pole().CompareTo(obj.Pole());
    }
}