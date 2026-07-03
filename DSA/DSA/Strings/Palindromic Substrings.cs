using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Palindromic_Substrings
    {
        public static int Palindromic(string s)
        {
            int count = 0;
            for(int i =0;i<s.Length;i++)
            {
                count += Expand(s, i, i);
                count += Expand(s, i, i + 1);
            }
            return count;
        }
        public static int Expand(string s,int left,int right)
        {
            int count = 0;
            while (left >= 0 && right < s.Length  && s[left] == s[right])
            {
                count++;

                left--;
                right++;
            }
            return count;
        }
    }
}
