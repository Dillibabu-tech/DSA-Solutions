using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class FindMinmumSubArray
    {
        static int Minsub(int[] num)
        {
            int min = 0;
            int max = num.Length - 1;
            while (min < max)
            {
                int mid = (min + max) / 2;
                if (num[mid] > num[max])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }
            }
            return num[max];
        }
    }
}
