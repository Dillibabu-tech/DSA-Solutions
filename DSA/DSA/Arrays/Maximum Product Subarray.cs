using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Maximum_Product_Subarray
    {
        public int MaxProduct(int[] nums)
        {
            int max = nums[0], min = nums[0], res = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int a = nums[i], prevMax = max;
                max = Math.Max(a, Math.Max(max * a, min * a));
                min = Math.Min(a, Math.Min(prevMax * a, min * a));
                res = Math.Max(res, max);
            }
            return res;
        }
    }
}
