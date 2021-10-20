using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static Dictionary<char, int> RomanToInt = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int RomanToInteger(string roman)
        {
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanToInt[roman[i]] < RomanToInt[roman[i + 1]])
                {
                    number -= RomanToInt[roman[i]];
                }
                else
                {
                    number += RomanToInt[roman[i]];
                }
            }
            return number;
        }
    }

}
