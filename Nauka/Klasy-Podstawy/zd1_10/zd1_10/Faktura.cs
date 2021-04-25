namespace zd1_10
{
    static class Faktura
    {
        public static double ObliczFV(double PV, double liczbaLat, double stopaProcentowa) =>
            PV * (1 + stopaProcentowa * liczbaLat);

        public static double ObliczPV(double FV, double liczbaLat, double stopaProcentowa) =>
            FV / (1 + stopaProcentowa * liczbaLat);

    }
}