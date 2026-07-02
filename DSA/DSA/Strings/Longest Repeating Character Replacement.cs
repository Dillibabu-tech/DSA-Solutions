using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Longest_Repeating_Character_Replacement
    {
        public static int Longestchar(string s,int n)
        {
            int max = 0;
            int min = 0;
            int res = 0;
            int[] curr = new int[26];
            for(int i = 0;i<s.Length;i++)
            {
                max = Math.Max(max, ++curr[s[i] - 'A']);
                while((i-min+1)- max>n)
                {
                    curr[s[min++] - 'A']--;
                }
                res = Math.Max(res, i - min + 1);
            }
            return res;
        }
    }
}
