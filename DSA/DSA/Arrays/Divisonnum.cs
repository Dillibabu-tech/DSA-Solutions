using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Divisonnum
    {
        static int[] divis(int[] nums)
        {
            int total = 1;
            foreach (int n in nums)
            {
                //total = n;
                total = total * n;
            }
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = total / nums[i];
            }
            return result;
        }
    }
}
