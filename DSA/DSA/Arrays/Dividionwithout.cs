using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Dividionwithout
    {
        static int[] divis(int[] nums)
        {
            int n = nums.Length;
            int[] n1 = new int[n];
            n1[0] = 1;
            for (int i = 1; i < n; i++)
            {
                n1[i] = n1[i - 1] * nums[i - 1];
            }
            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                n1[i] = n1[i] * right;
                right = right * nums[i];
            }
            return n1;
        }
    }
}
