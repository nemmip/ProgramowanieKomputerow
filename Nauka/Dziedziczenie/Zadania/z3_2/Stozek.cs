﻿using System;

namespace z3_2
{
    class Stozek
    {
        protected double r1;//promien podstawy
        protected double tworzacaStozka;

        public Stozek(double r1, double tworzacaStozka)
        {
            this.r1 = r1;
            this.tworzacaStozka = tworzacaStozka;
        }

        public virtual double PowierzchniaBocznaStozka() => Math.PI * tworzacaStozka * r1;

    }
}