using System;

namespace zad5_3
{
    public class Osoba : IComparable<Osoba>

    {
    private string imie;
    private string nazwisko;

    public Osoba(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }

    public int CompareTo(Osoba? other)
    {
        if (other == null) return 1;
        int wynik = nazwisko.CompareTo(other.nazwisko);
        if (wynik == 0)
            wynik = imie.CompareTo(other.imie);
        return wynik;
    }

    public override string ToString() => $"{imie} {nazwisko}";
    }
}