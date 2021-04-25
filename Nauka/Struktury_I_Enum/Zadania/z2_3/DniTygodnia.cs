using System;

namespace z2_3
{
    [Flags]//do flagowania najlepiej uzyc kolejnych potęg 2
    public enum DniTygodnia
    {
        Niedziela=1,
        Poniedzialek=2,
        Wtorek=4,
        Sroda=8,
        Czwartek=16,
        Piatek=32,
        Sobota=64,
        DniRobocze=Poniedzialek|Wtorek|Sroda|Czwartek|Piatek,
        DniWolne=Sobota|Niedziela
    }
}