using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class TwoSum
    {
        static int[] profit(int[] num, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < num.Length; i++)
            {
                int comp = target - num[i];
                if (map.ContainsKey(comp))
                {
                    return new int[] { map[comp], i };
                }
                map[num[i]] = i;
            }
            return Array.Empty<int>();
        }
       
    }
}
