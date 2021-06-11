using System.Collections.Generic;

namespace zad5_4
{
    public static class AnalizaNawiasow
    {
        private static readonly char nawiasOtwierajacy = '(';
        private static readonly char nawiasZamykajacy = ')';

        public static bool SprawdzNawiasy(string wyrazenie)
        {
            Stack<bool> nawiasy = new Stack<bool>();
            foreach (char znak in wyrazenie)
            {
                if (znak==nawiasOtwierajacy)
                {
                    nawiasy.Push(true);
                }
                else if (znak==nawiasZamykajacy)
                {
                    if (nawiasy.Count == 0) return false;
                    nawiasy.Pop();
                }
            }

            return nawiasy.Count == 0;
        }
    }
}