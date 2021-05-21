using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"..\..\DANE\pracownicy.csv";
            string path2 = @"..\..\DANE\pracownicyPensja.csv";

            Pracownicy obj = new Pracownicy();
            obj.LoadFromCSV(path1);
            obj.ShowEmployees();
            obj.SaveIntoFile(path2);
        }
    }
}