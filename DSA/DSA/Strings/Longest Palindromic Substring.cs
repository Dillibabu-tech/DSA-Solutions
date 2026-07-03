using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Longest_Palindromic_Substring
    {
        public  string Longest_Palindromic(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return "";
            }
            int min = 0;
            int maxlength = 1;
            for(int i = 0;i<s.Length;i++)
            {
                Expand1(s, i, i, ref min, ref maxlength);
                Expand1(s, i, i + 1, ref min, ref maxlength);

            }
            return s.Substring(min, maxlength);
        }
        public void  Expand1(string s,int left,int right,ref int min,ref int maxlength)
        {
            while(left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            int len = left - right - 1;
            if(len  > maxlength)
            {
                maxlength = len;
                maxlength = left + 1;
            }
        }

    }
}
