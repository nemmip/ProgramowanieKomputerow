using System;

namespace PD1
{
    public class Lancuch
    {
        private string _wejscie;

        public Lancuch(string wejscie)
        {
            this._wejscie = wejscie;
        }

        public int ZwrocLiczbe()
        {
            string ciagLiczb = default;
            foreach (char c in _wejscie)
                ciagLiczb += (int.TryParse(c.ToString(), out int result)) ? result : String.Empty;
            long.TryParse(ciagLiczb, out long liczba);
            return (liczba <= Int32.MaxValue) ? (int)liczba : -1;

        }

        public string ZmienLitery()
        {
            string wyjscie = default;
            for(int i=0; i<_wejscie.Length;i++)
            {
                if (Char.IsLower(_wejscie[i]))
                    wyjscie += Char.ToUpper(_wejscie[i]);
                else if (Char.IsUpper(_wejscie[i]))
                    wyjscie += Char.ToLower(_wejscie[i]);
                else
                    wyjscie += _wejscie[i];
            }
            return wyjscie;
        }
    }
}