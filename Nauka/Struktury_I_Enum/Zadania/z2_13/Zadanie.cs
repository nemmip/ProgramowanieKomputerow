using System;

namespace z2_13
{
    public class Zadanie
    {
        private string nazwaZadania;
        private PriorytetZadania priorytet;
        private DateTime termin;
        public bool CzyWykonane { get; set; }

        public Zadanie(string nazwaZadania, PriorytetZadania priorytet, DateTime termin, bool czyWykonane = false)
        {
            this.nazwaZadania = nazwaZadania;
            this.priorytet = priorytet;
            this.termin = termin;
            this.CzyWykonane = czyWykonane;
        }

        private string StanWykonania() => CzyWykonane ? "Zrobione" : "Do zrobienia";
        private string PriorytetWysoki() => priorytet == PriorytetZadania.Wysoki ? "!" : String.Empty;
        private string PoTerminie() => !CzyWykonane && termin < DateTime.Now ? "Po terminie" : String.Empty;

        public override string ToString() => $"{nazwaZadania,-20} {priorytet,-8} {termin.ToShortDateString(),-11} {Dzien(),-20}" +
                                             $" {StanWykonania(),-13} {PriorytetWysoki(),-3} {PoTerminie()}";

        private string Dzien()
        {
            string wynik = default;
            int nrDnia = (int) termin.DayOfWeek;
            nrDnia = 1 << nrDnia; //znak <<  przesunięcie bitowe
            wynik = ((DniTygodnia) nrDnia).ToString();
            if (DniTygodnia.DniRobocze.HasFlag((DniTygodnia) nrDnia))
                wynik += " (roboczy)";
            else if (DniTygodnia.DniWolne.HasFlag((DniTygodnia) nrDnia))
                wynik += " (wolny)";
            return wynik;
        }

    }
}