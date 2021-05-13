using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gap(32));
            
        }

        static int gap(int N)
        {
            string binary = toBinary(ref N);
            bool secondOne = true;
            int counter = default;
            List<int> gaps = new List<int>();
            for (int i = 0; i < binary.Length; i++)
            {
                if (secondOne && binary[i]=='1')
                {
                    secondOne = false;
                }
                else if (binary[i]=='0')
                {
                    counter++;
                    secondOne = false;
                }
                else if (binary[i] == '1')
                {
                    gaps.Add(counter);
                    secondOne = true;
                    counter = 0;
                }
            }

            return gaps.Count == 0 ? 0 : gaps.Max();
        }
        static string toBinary(ref int number)
        {
            string binary = default;
            while (number!=0)
            {
                binary += number % 2 == 0 ? '0' : '1';
                number /= 2;
            }

            char[] arr = binary.ToCharArray();
            
            binary = String.Concat(arr.Reverse());
            
            return binary;
        }
        
    }
}