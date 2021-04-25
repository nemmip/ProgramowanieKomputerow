using System;

namespace z3_1
{
    class StozekSciety:Stozek
    {
        private double r2;//promien scietej
        public StozekSciety(double r1, double tworzacaStozka, double r2) : base(r1, tworzacaStozka) => this.r2 = r2;
        public double PowierzchniaBocznaStozkaScietego() => Math.PI * tworzacaStozka * (r1 + r2);

    }
}