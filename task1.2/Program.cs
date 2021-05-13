using System;

namespace task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Platform Team";
            Console.WriteLine(s);
            Console.WriteLine(nonUnique(s));
        }

        static string nonUnique(string S)
        {
            int[] ascii = new int [127];
            int indexToRemove;
            S = S.ToLower().Trim();
            foreach (char c in S)
                ascii[(byte) c]++;
            
            for (int i = 0; i < ascii.Length; i++)
            {
                if (ascii[i]==1)
                {
                    indexToRemove = S.IndexOf((char) i);
                    S=S.Remove(indexToRemove,1);
                }
            }
            return S;
        }
    }
}