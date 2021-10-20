using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            SortCol(nums);
        }
        
        public static void SortCol(int[] nums)
        {
            Array.Sort(nums);
            Console.WriteLine(nums);
            Console.ReadLine();
        }
    }
}
