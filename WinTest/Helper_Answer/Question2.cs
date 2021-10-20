using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinTest.Helper_Answer
{
    public class Question2
    {
        public static Dictionary<char, int> RomanToIntDic = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int RomToInt(string s)
        {
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && RomanToIntDic[s[i]] < RomanToIntDic[s[i + 1]])
                {
                    number -= RomanToIntDic[s[i]];
                }
                else
                {
                    number += RomanToIntDic[s[i]];
                }
            }
            return number;
        }
    }
}