using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Maximum_Subarray__Kadane_s_
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0], cur = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                cur = Math.Max(nums[i], cur + nums[i]);
                maxSum = Math.Max(maxSum, cur);
            }
            return maxSum;
        }
    }
}
