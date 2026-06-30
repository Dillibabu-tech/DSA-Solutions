using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class findduplicate
    {
        static bool findduplicate1(int[] num)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int n in num)
            {
                if (!seen.Add(n))
                    return true;
            }
            return false;
        }
    }
}
