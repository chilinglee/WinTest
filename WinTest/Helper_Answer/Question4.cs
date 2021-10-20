using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinTest.Helper_Answer
{
    public class Question4
    {
        public void SortCol(int[] nums)
        {
            Array.Sort(nums);
           foreach(int n in nums)
            {
                Console.WriteLine(n);
            }
        }
    }
}