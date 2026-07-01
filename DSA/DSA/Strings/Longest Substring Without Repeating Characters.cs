using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Longest_Substring_Without_Repeating_Characters
    {
        public static int LongestSubstring(String s)
        {
            HashSet<char> str = new HashSet<char>();
            int min = 0;
            int max = 0;
            for(int i =0;i<s.Length;i++)
            {
                while (str.Contains(s[i]))
                {
                    str.Remove(s[min++]);
                }
                str.Add(s[i]);
                max = Math.Max(max, i - min + 1);
            }
            return max;
        }
    }
}
