﻿using System;
using System.Collections.Generic;

namespace zad5_2_2
{
    public class Osoby<T>:List<T>,IWypisz
    {
        public void Wypisz()
        {
            foreach (T osoby in this)
            {
                Console.WriteLine("Pan/Pani "+osoby.ToString());
            }
        }
    }
}