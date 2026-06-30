using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Container_With_Most_Water
    {
        public static int Container(int[] height)
        {
            int min = 0;
            int max = height.Length - 1;
            int result = 0;
            while (max > min)
            {
                result = Math.Max(max, Math.Min(height[min], height[max] - (min * max)));

                if (height[max] > height[min])
                {
                    min++;
                }
                else
                {
                    min--;
                }
            }
            return result;
        }
    }
}
